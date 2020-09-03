using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;

namespace WolvenKit
{
    public partial class frmMenuCreator : Form
    {
        private WitcherMenu MenuObject;

        public const string BrokenXmlHeader = "<?xml version=\"1.0\" encoding=\"UTF-16\"?>";



        public frmMenuCreator()
        {
            InitializeComponent();
            MenuObject = new WitcherMenu();
            MenuEditor.SelectedObject = MenuObject;

            this.Icon = new Icon(@"Resources\Icons\GUI\Wkit_dark_16x.ico", new Size(16, 16));

        }

        private void PaintMenuTree()
        {
            menutree.Nodes.Clear();
            List<TreeNode> nodes = new List<TreeNode>();
            foreach (var g in MenuObject.Groups)
            {
                TreeNode gnode = new TreeNode(g.DisplayName);
                gnode.Tag = g;
                if (g.Presets != null && g.Presets.Count > 0)
                {
                    TreeNode gpresets = new TreeNode("Presets");
                    gpresets.Tag = g.Presets;
                    foreach (var p in g.Presets)
                    {
                        TreeNode pres = new TreeNode(p.DisplayName);
                        pres.Tag = p;
                        gpresets.Nodes.Add(pres);
                    }
                    gnode.Nodes.Add(gpresets);
                }

                if (g.Variables != null && g.Variables.Count > 0)
                {
                    TreeNode gvars = new TreeNode("Variables");
                    gvars.Tag = g.Variables;
                    foreach (var p in g.Variables)
                    {
                        TreeNode var = new TreeNode(p.DisplayName);
                        var.Tag = p;
                        gvars.Nodes.Add(var);
                    }
                    gnode.Nodes.Add(gvars);
                }
                nodes.Add(gnode);
            }
            menutree.Nodes.AddRange(nodes.ToArray());
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var sf = new SaveFileDialog
                {
                    Title = "Select a path to save the serialized menu.",
                    Filter = "XML Files | *.xml"
                };
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    var menu = new XDocument(new XElement("UserConfig", MenuObject.Groups.Select(SerializeGroup)));
                    menu.Save(sf.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save the document!\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !DEBUG
            
            try
            {
#endif 
                var of = new OpenFileDialog
                {
                    Title = @"Select the xml file to load!",
                    Filter = @"XML Files | *.xml"
                };
                if (of.ShowDialog() == DialogResult.OK)
                {
                    var loadedxml = XDocument.Parse(System.IO.File.ReadAllText(of.FileName));
                    MenuObject.Groups = loadedxml.Root?.Elements("Group").Select(DeserializeGroup).ToList();
                    PaintMenuTree();
                }
#if !DEBUG
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Couldn't load the selected xml file.
Please make sure you have selected a valid one.
Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
#endif
        }
        
        private void menutree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MenuEditor.SelectedObject = e.Node.Tag;
        }

        private void editMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEditor.SelectedObject = MenuObject;
        }

        private void MenuEditor_SelectedObjectsChanged(object sender, EventArgs e)
        {
            
        }

        public class WitcherMenuElementEditor : CollectionEditor
        {
            public WitcherMenuElementEditor(Type type)
                : base(type)
            {
            }

            protected override string GetDisplayText(object value)
            {
                return base.GetDisplayText(string.Format(((WitcherMenuElement)value).DisplayName));
            }
        }

        #region Classes & (De)Serialization
        public static WitcheMenuGroup DeserializeGroup(XElement element)
        {
            return new WitcheMenuGroup
            {
                ID = element.Attribute("id")?.Value,
                DisplayName = element.Attribute("displayName")?.Value,
                Presets = DeserializePresets(element.Element("PresetsArray")),
                Variables = element.Element("VisibleVars")?.Elements("Var").Select(DeserializeVariable).ToList()
            };
        }

        public static XElement SerializeGroup(WitcheMenuGroup group)
        {
            var serialized = new XElement("Group",
                new XAttribute("id", group.ID),
                new XAttribute("displayName", group.DisplayName));
            if(group.Variables != null)
                serialized.Add(new XElement("VisibleVars", group.Variables.Select(SerializeVariable)));
            if (group.Presets != null)
                serialized.Add(SerializePresets(group.Presets));
            return serialized;
        }

        public static WitcherMenuVariable DeserializeVariable(XElement element)
        {
            var ret = new WitcherMenuVariable
            {
                ID = element.Attribute("id")?.Value,
                DisplayName = element.Attribute("displayName")?.Value,
                Tags = element.Attribute("tags")?.Value.Split(';').ToList()
            };
            if (element.Attribute("displayType") != null && element.Attribute("displayType").Value.StartsWith("TOGGLE"))
            {
                ret.Variabletype = WitcherMenuVariableType.TOGGLE;
            }
            else if (element.Attribute("displayType").Value.StartsWith("SLIDER"))
            {
                ret.Variabletype = WitcherMenuVariableType.SLIDER;
                var split =  element.Attribute("displayType").Value.Split(';');
                if (split.Length > 3)
                {
                    ret.MinValue = split[1];
                    ret.MaxValue = split[2];
                    ret.Step = split[3];
                }
            }
            else if (element.Attribute("displayType").Value.StartsWith("OPTIONS"))
            {
                ret.Variabletype = WitcherMenuVariableType.OPTIONS;
                ret.Options = DeseralizeOptions(element.Element("OptionsArray"));
            }
            else
            {
                throw new Exception("Invalid variable type! Can't parse. Type: " + element.Attribute("displayType")?.Value);
            }
            return ret;
        }

        public static XElement SerializeVariable(WitcherMenuVariable var)
        {
            switch (var.Variabletype)
            {
                case WitcherMenuVariableType.OPTIONS:
                    return new XElement("Var",
                        new XAttribute("id", var.ID),
                        new XAttribute("displayName", var.DisplayName),
                        new XAttribute("displayType",var.Variabletype),
                        new XAttribute("tags",string.Join(";", var.Tags)),
                        SerializeOptions(var.Options));
                case WitcherMenuVariableType.SLIDER:
                    return new XElement("Var",
                        new XAttribute("id", var.ID),
                        new XAttribute("displayName", var.DisplayName),
                        new XAttribute("displayType",
                            var.Variabletype + ";" + var.MinValue + ";" + var.MaxValue + ";" + var.Step),
                        new XAttribute("tags", string.Join(";", var.Tags)));
                case WitcherMenuVariableType.TOGGLE:
                    return new XElement("Var",
                        new XAttribute("id", var.ID),
                        new XAttribute("displayName", var.DisplayName),
                        new XAttribute("displayType", var.Variabletype),
                        new XAttribute("tags", string.Join(";", var.Tags)));
                default:
                    throw new Exception("Invalid variable type!");
            }   
        }

        public static List<WitcherVariableOption> DeseralizeOptions(XElement element)
        {
            var ret = new List<WitcherVariableOption>();
            foreach (var option in element.Elements("Option"))
            {
                var wvo = new WitcherVariableOption
                {
                    ID = option.Attribute("id")?.Value,
                    DisplayName = option.Attribute("displayName")?.Value
                };
                foreach (var ent in option.Elements("Entry").Select(entry => new PresetEntry { VarId = entry.Attribute("varId")?.Value, Value = entry.Attribute("value")?.Value }))
                {
                    wvo.Entries.Add(ent);
                }
                ret.Add(wvo);
            }
            return ret;
        }

        public static XElement SerializeOptions(List<WitcherVariableOption> presets)
        {
            return new XElement("OptionsArray", presets.Select(x =>
                                 new XElement("Option",
                                     new XAttribute("id", x.ID),
                                     new XAttribute("displayName", x.DisplayName),
                                     x.Entries.Select(y => new XElement("Entry",
                                                             new XAttribute("varId", y.VarId),
                                                             new XAttribute("value", y.Value))).ToArray())));
        }

        public static List<WitcherMenuPreset> DeserializePresets(XElement element)
        {
            if(element == null)
                return null;
            var ret = new List<WitcherMenuPreset>();
            foreach (var xElement in element.Elements("Preset"))
            {
                var preset = new WitcherMenuPreset
                {
                    ID = xElement.Attribute("id")?.Value,
                    DisplayName = xElement.Attribute("displayName")?.Value,
                    Tags = xElement.Attribute("tags")?.Value.Split(';').ToList()
                };
                foreach (var pentry in xElement.Elements("Entry").Select(entry => new PresetEntry
                {
                    VarId = entry.Attribute("varId")?.Value,
                    Value = entry.Attribute("value")?.Value
                }))
                {
                    preset.Entries.Add(pentry);
                }
                ret.Add(preset);
            }
            return ret;
        }

        public static XElement SerializePresets(List<WitcherMenuPreset> presets)
        {
            return new XElement("PresetsArray",presets.Select(x=>
                                new XElement("Preset",
                                    new XAttribute("id",x.ID),
                                    new XAttribute("displayName", x.DisplayName),
                                    new XAttribute("tags", string.Join(";", x.Tags)),
                                    x.Entries.Select(y=> new XElement("Entry",
                                                            new XAttribute("varId",y.VarId),
                                                            new XAttribute("value",y.Value))).ToArray())));
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

            [Editor(typeof(WitcherMenuElementEditor),typeof(System.Drawing.Design.UITypeEditor))]
            private List<WitcheMenuGroup> groups = new List<WitcheMenuGroup>();
        }

        [RefreshProperties(RefreshProperties.All)]
        public class WitcheMenuGroup : WitcherMenuElement
        {
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
            public List<WitcherVariableOption> Options
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

            private List<WitcherVariableOption> _entries = new List<WitcherVariableOption>();

            private WitcherMenuVariableType variableType = WitcherMenuVariableType.TOGGLE;
        }

        [RefreshProperties(RefreshProperties.All)]
        public class WitcherVariableOption : WitcherMenuElement
        {
            [Category("Sections")]
            [Description("The entries inside this option.")]
            [Editor(typeof(DescriptiveCollectionEditor), typeof(UITypeEditor))]
            public List<PresetEntry> Entries
            {
                get { return _entries; }
                set { _entries = value; }
            }

            private List<PresetEntry> _entries = new List<PresetEntry>();
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

        /// <summary>
        /// Naming must be exact.
        /// </summary>
        public enum WitcherMenuVariableType
        {
            OPTIONS,
            SLIDER,
            TOGGLE
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
        #endregion

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaintMenuTree();
        }
    }
}
