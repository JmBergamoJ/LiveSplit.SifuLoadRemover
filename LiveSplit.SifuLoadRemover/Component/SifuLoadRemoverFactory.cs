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
            get
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                var fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
                string version = fvi.FileVersion;
                Version.TryParse(version, out var res);
                return res;
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
