using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.SifuLoadRemover.Misc.Extensions
{
    public static class ComponentExtensions
    {
        public static void BindEnumToCombobox<T>(this ComboBox comboBox, T defaultSelection) where T : Enum
        {
            var list = Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(value => new
                {
                    Description = value.Description(),
                    Value = value
                })
                .OrderBy(item => item.Value.ToString())
                .ToList();

            comboBox.DataSource = list;
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Value";

            foreach (var opts in list)
            {
                if (opts.Value.ToString() == defaultSelection.ToString())
                {
                    comboBox.SelectedItem = opts;
                }
            }
        }
    }
}
