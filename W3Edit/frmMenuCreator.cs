using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WolvenKit
{
    public partial class frmMenuCreator : Form
    {
        public static WitcherMenu Menu;

        public frmMenuCreator()
        {
            InitializeComponent();
            Menu = new WitcherMenu();
            propertyGrid1.SelectedObject = Menu;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sf = new SaveFileDialog();
            sf.Title = "Select a path to save the serialized menu.";
            sf.Filter = "XML Files | *.xml";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                XDocument menu = new XDocument(new XElement("UserConfig", Menu.Groups.Select(ParseGroup).ToArray()));
                menu.Declaration = new XDeclaration("1.0", "UTF-16", "no");
                menu.Save(sf.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public static XElement ParseGroup(WitcheMenuGroup group)
        {
            if (group.SubGroups == null || group.SubGroups.Count == 0)
            {
                return new XElement("Group", new XAttribute("id", group.ID), new XAttribute("displayName", group.DisplayName));
            }
            return new XElement("Group", new XAttribute("id", group.ID), new XAttribute("displayName", group.DisplayName),
                group.SubGroups.Select(ParseGroup).ToArray());
        }

        public static XElement ParseVariables(WitcherMenuVariable var)
        {
            switch (var.Variabletype)
            {
                case WitcherMenuVariableType.Option:
                    return new XElement("Group", new XAttribute("id", var.ID), new XAttribute("displayName", var.DisplayName));
                case WitcherMenuVariableType.Slider:
                    return new XElement("Group", new XAttribute("id", var.ID), new XAttribute("displayName", var.DisplayName));
                case WitcherMenuVariableType.Toggle:
                    return new XElement("Group", new XAttribute("id", var.ID), new XAttribute("displayName", var.DisplayName));
                default:
                    throw new Exception("Invalid variable type!");
            }   
        }

        public static XElement ParsePresets(List<WitcherMenuPreset> presets)
        {
            return new XElement("PresetsArray",presets.Select(x=>
                                new XElement("Preset",
                                    new XAttribute("id",x.ID),
                                    new XAttribute("displayName", x.DisplayName),
                                    new XAttribute("tags", x.Tags.Aggregate("",(c,n)=> c += ";" + n)),
                                    x.Entries.Select(y=> new XElement("Entry",
                                                            new XAttribute("varId",y.VarId),
                                                            new XAttribute("value",y.Value))).ToArray())));
        }

        public void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
           
        }

        [RefreshProperties(RefreshProperties.All)]
        public class WitcherMenu
        {
            [Category("Sections")]
            [Description("These are the groups/menus in your menu. (Inside this you can create submenus or variables)")]
            [Editor(typeof(DescriptiveCollectionEditor), typeof(UITypeEditor))]
            public List<WitcheMenuGroup> Groups
            {
                get { return groups; }
                set { groups = value; }
            }

            private List<WitcheMenuGroup> groups = new List<WitcheMenuGroup>();

        }

        [RefreshProperties(RefreshProperties.All)]
        public class WitcheMenuGroup : WitcherMenuElement
        {
            [Category("Sections")]
            [Description("The SubGroups of the group if this is not null then everything else isn't serialized.")]
            [Editor(typeof(DescriptiveCollectionEditor), typeof(UITypeEditor))]
            public List<WitcheMenuGroup> SubGroups
            {
                get { return subgroups; }
                set { subgroups = value; }
            }
            private List<WitcheMenuGroup> subgroups = new List<WitcheMenuGroup>();
            [Category("Sections")]
            [Description("The variables of the group. These are the actual settings (sliders,toggles,options)")]
            [Editor(typeof(DescriptiveCollectionEditor), typeof(UITypeEditor))]
            public List<WitcherMenuVariable> Variables
            {
                get { return variables; }
                set { variables = value; }
            }
            private List<WitcherMenuVariable> variables = new List<WitcherMenuVariable>();
            [Category("Sections")]
            [Description("The presets of the group. (these can be used to create preset variable values)")]
            [Editor(typeof(DescriptiveCollectionEditor), typeof(UITypeEditor))]
            public List<WitcherMenuPreset> Presets
            {
                get { return presets; }
                set { presets = value; }
            }
            private List<WitcherMenuPreset> presets = new List<WitcherMenuPreset>();
        }

        [RefreshProperties(RefreshProperties.All)]
        public class WitcherMenuVariable : WitcherMenuElement
        {
            [Category("Main variables")]
            [Description("The tags of the element.")]
            [Editor(@"System.Windows.Forms.Design.StringCollectionEditor," +
"System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
typeof(System.Drawing.Design.UITypeEditor))]
            public List<string> Tags
            {
                get { return tags; }
                set { tags = value; }
            }

            [Category("Type")]
            [Description("The type of the variable.\nNote: Only the properties in the section this is set to are serialized.")]
            public WitcherMenuVariableType Variabletype
            {
                get { return variableType; }
                set { variableType = value; }
            }

            private List<string> tags = new List<string>();

            [Category("Options")]
            [Description("The different options this option variable has.")]
            [Editor(typeof(DescriptiveCollectionEditor), typeof(UITypeEditor))]
            public List<PresetEntry> Options
            {
                get { return _entries; }
                set { _entries = value; }
            }

            [Category("Slider")]
            [Description("The minimum value of the slider.")]
            public string MinValue
            {
                get { return min; }
                set { min = value; }
            }
            private string min = "";
            [Category("Slider")]
            [Description("The max value of the slider.")]
            public string MaxValue
            {
                get { return max; }
                set { max = value; }
            }
            private string max = "";
            [Category("Slider")]
            [Description("The number of steps in the slider.")]
            public string Step
            {
                get { return step; }
                set { step = value; }
            }
            private string step = "";

            private List<PresetEntry> _entries = new List<PresetEntry>();

            private WitcherMenuVariableType variableType = WitcherMenuVariableType.Toggle;
        }

        [RefreshProperties(RefreshProperties.All)]
        public class WitcherMenuPreset : WitcherMenuElement
        {
            [Category("Sections")]
            [Description("The tags of this presetarray.")]
            [Editor(@"System.Windows.Forms.Design.StringCollectionEditor," +
            "System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
           typeof(System.Drawing.Design.UITypeEditor))]
            public List<string> Tags
            {
                get { return tags; }
                set { tags = value; }
            }
            private List<string> tags = new List<string>();

            [Category("Sections")]
            [Description("These are the Entries this preset modifies when clicked.")]
            [Editor(typeof(DescriptiveCollectionEditor), typeof(UITypeEditor))]
            public List<PresetEntry> Entries
            {
                get { return _entries; }
                set { _entries = value; }
            }

            private List<PresetEntry> _entries = new List<PresetEntry>();
        }

        [RefreshProperties(RefreshProperties.All)]
        public class PresetEntry
        {
            [Category("Sections")]
            [Description("The id of the entry.")]
            public string VarId
            {
                get { return varId; }
                set { varId = value; }
            }
            private string varId = "";

            [Category("Sections")]
            [Description("The value of the entry.")]
            public string Value
            {
                get { return _Value; }
                set { _Value = value; }
            }
            private string _Value = "";
        }

        [RefreshProperties(RefreshProperties.All)]
        public abstract class WitcherMenuElement
        {
            [Category("Main variables")]
            [Description("The id of the element.")]
            public string ID
            {
                get { return id; }
                set { id = value; }
            }
            private string id = "";
            [Category("Main variables")]
            [Description("The displayed name for the element.")]
            public string DisplayName
            {
                get { return displayname; }
                set { displayname = value; }
            }
            private string displayname = "";
        }

        public enum WitcherMenuVariableType
        {
            Option,
            Slider,
            Toggle
        }

        class DescriptiveCollectionEditor : CollectionEditor
        {
            public DescriptiveCollectionEditor(Type type) : base(type) { }
            protected override CollectionForm CreateCollectionForm()
            {
                CollectionForm form = base.CreateCollectionForm();
                form.Shown += delegate
                {
                    ShowDescription(form);
                };
                return form;
            }
            static void ShowDescription(Control control)
            {
                PropertyGrid grid = control as PropertyGrid;
                if (grid != null) grid.HelpVisible = true;
                foreach (Control child in control.Controls)
                {
                    ShowDescription(child);
                }
            }
        }

    }
}
