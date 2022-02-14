using LiveSplit.Model;
using LiveSplit.SifuLoadRemover.Component;
using LiveSplit.SifuLoadRemover.Imports;
using LiveSplit.SifuLoadRemover.Misc;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[assembly: ComponentFactory(typeof(SifuLoadRemoverFactory))]
namespace LiveSplit.SifuLoadRemover.Component
{
    public class SifuLoadRemoverFactory : IComponentFactory
    {
        public string ComponentName
        {
            get { return Constants.Component.Name; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Control; }
        }

        public string Description
        {
            get { return Constants.Component.Description; ; }
        }

        public IComponent Create(LiveSplitState state)
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(Resolver);
            EnsureTessDataFilesArePresent();
            return new SifuLoadRemoverComponent(state);
        }
        public string UpdateName
        {
            get { return ComponentName; }
        }
        public string UpdateURL => Constants.Component.UpdateURL;
        public string XMLURL => UpdateURL + "update.LiveSplit.SifuLoadRemover.xml";


        public Version Version
        {
            get { return Version.Parse("1.0"); }
        }


        private void EnsureTessDataFilesArePresent()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyDirectory = Path.GetDirectoryName(assembly.Location);
            var tessDataDir = Path.Combine(assemblyDirectory, "SifuLoadRemover-tessdata");
            if (!Directory.Exists(tessDataDir))
                Directory.CreateDirectory(tessDataDir);


            foreach (var item in assembly.GetManifestResourceNames().Where(r => r.Contains("tessdata")))
            {
                using (var resource = assembly.GetManifestResourceStream(item))
                {
                    var filePath = item.Split('.');
                    string filename = $"{filePath[filePath.Length - 2]}.{filePath[filePath.Length - 1]}";
                    if (!File.Exists($@"{tessDataDir}\{filename}"))
                    {
                        using (var file = new FileStream($@"{tessDataDir}\{filename}", FileMode.Create, FileAccess.Write))
                        {
                            resource.CopyTo(file);
                        }
                    }
                }
            }
        }

        static Assembly Resolver(object sender, ResolveEventArgs args)
        {
            Assembly a1 = Assembly.GetExecutingAssembly();
            var resourcename = a1.GetManifestResourceNames().FirstOrDefault((r) => r.Contains(args.Name.Substring(0, args.Name.IndexOf(','))));
            if (!string.IsNullOrEmpty(resourcename))
            {
                Stream s = a1.GetManifestResourceStream(resourcename);
                byte[] block = new byte[s.Length];
                s.Read(block, 0, block.Length);
                Assembly a2 = Assembly.Load(block);
                return a2;
            }
            return null;
        }
    }
}
