using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.Extensions;
using WolvenKit.Forms.Editors;

namespace WolvenKit.Utility
{
    public static class EditorHandler
    {
        public static Control GetEditor(object obj)
        {
            switch (obj)
            {
                case IArrayAccessor iarray:
                {
                    return iarray.InnerType.GetInterface(nameof(IREDPrimitive)) == null 
                        ? null 
                        : new ArrayEditor { WrappedArray = iarray };
                }
                case IPtrAccessor o:
                    return o.GetEditor();
                case IEnumAccessor o:
                    return o.GetEditor();
                case ISoftAccessor o:
                    return o.GetEditor();
                case IHandleAccessor o:
                    return o.GetEditor();
                case IVariantAccessor o:
                    return o.GetEditor();
                case StringAnsi _:
                case CBool _:
                case CVLQInt32 _:
                case CDynamicInt _:
                case CInt8 _:
                case CInt16 _:
                case CInt32 _:
                case CInt64 _:
                case CUInt8 _:
                case CUInt16 _:
                case CUInt32 _:
                case CUInt64 _:
                case CString _:
                case LocalizedString _:
                    var editor = new TextBox();
                    editor.DataBindings.Add("Text", obj, "val");
                    return editor;
                case IByteSource o:
                    return new ByteArrayEditor { Variable = o };
                case CGUID o:
                    return o.GetEditor();
                case CFloat o:
                    return o.GetEditor();
                case IdTag o:
                    return o.GetEditor();
                case CName o:
                    return o.GetEditor();
                case CColorShift o:
                    return o.GetEditor();
                case CColor o:
                    return o.GetEditor();
                case CXml o:
                    return o.GetEditor();
                default:
                    return null;
            }
        }

        private static Control GetEditor(this IPtrAccessor @this)
        {
            
            var editor = new ComboBox();
            editor.UpdateComboBoxWith(@this);

            return editor;
        }
        private static Control GetEditor(this ISoftAccessor @this)
        {
            var editor = new PtrEditor();
            editor.HandlePath.DataBindings.Add("Text", @this, nameof(@this.DepotPath), true, DataSourceUpdateMode.OnPropertyChanged);
            editor.FileType.DataBindings.Add("Text", @this, nameof(@this.ClassName), true, DataSourceUpdateMode.OnPropertyChanged);
            //editor.Flags.DataBindings.Add("Text", this, nameof(Flags), true, DataSourceUpdateMode.OnPropertyChanged);
            return editor;
        }
        private static Control GetEditor(this IHandleAccessor @this)
        {
            if (@this.ChunkHandle)
            {
                var editor = new ComboBox();
                editor.UpdateComboBoxWith(@this);

                return editor;
            }
            else
            {
                var editor = new PtrEditor();
                editor.HandlePath.DataBindings.Add("Text", @this, nameof(@this.DepotPath), true, DataSourceUpdateMode.OnPropertyChanged);
                editor.FileType.DataBindings.Add("Text", @this, nameof(@this.ClassName), true, DataSourceUpdateMode.OnPropertyChanged);
                //editor.Flags.DataBindings.Add("Text", this, nameof(Flags), true, DataSourceUpdateMode.OnPropertyChanged);
                return editor;
            }
        }
        private static Control GetEditor(this IEnumAccessor @this)
        {
            if (@this.GetEnumType().IsDefined(typeof(FlagsAttribute), false))
            {
                // add all values to 
                CheckedListBox clb = new CheckedListBox();
                clb.Items.AddRange(@this.GetEnumType().GetEnumNames());
                //clb.Height = clb.Items.Count * clb.ItemHeight;

                for (int i = 0; i < @this.GetEnumType().GetEnumNames().Count(); i++)
                {
                    string s = @this.GetEnumType().GetEnumNames()[i];
                    if (@this.Value.Contains(s))
                        clb.SetItemChecked(i, true);
                }
                clb.SelectedValueChanged += HandleEnumPick;
                return clb;
            }
            else
            {
                ComboBox cb = new ComboBox();
                cb.Items.AddRange(@this.GetEnumType().GetEnumNames());

                cb.SelectedValue = @this.EnumToString();
                cb.SelectedValueChanged += HandleEnumPick;
                return cb;
            }

            void HandleEnumPick(object sender, EventArgs e)
            {
                if (@this.IsFlag)
                {
                    List<string> enumstrings = new List<string>();
                    foreach (var item in (sender as CheckedListBox).CheckedItems)
                    {
                        if (item is string enumstring)
                        {
                            enumstrings.Add(enumstring);
                        }
                    }
                    @this.SetValue(enumstrings);
                }
                else
                {
                    if ((sender as ComboBox).SelectedItem is string enumstring)
                    {
                        @this.SetValue(new List<string>() { enumstring });
                    }
                }
            }
        }
        private static Control GetEditor(this CGUID @this)
        {
            var editor = new TextBox();
            editor.Margin = new Padding(3, 3, 3, 0);
            editor.DataBindings.Add("Text", @this, "GuidString");
            return editor;
        }
        private static Control GetEditor(this CFloat @this)
        {
            var editor = new TextBox
            {
                Margin = new Padding(3, 3, 3, 0)
            };
            editor.DataBindings.Add("Text", @this, "val");
            return editor;
        }
        private static Control GetEditor(this IdTag @this)
        {
            var editor = new IdTagEditor();
            editor.IdType.DataBindings.Add("Text", @this, "TypeString", true, DataSourceUpdateMode.OnPropertyChanged);
            editor.IdGuid.DataBindings.Add("Text", @this, "GuidString", true, DataSourceUpdateMode.OnPropertyChanged);
            return editor;
        }
        private static Control GetEditor(this IVariantAccessor @this) => EditorHandler.GetEditor(@this.Variant);
        private static Control GetEditor(this CName @this)
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", @this, nameof(@this.Value));
            return editor;
        }
        private static Control GetEditor(this CColorShift @this)
        {
            var panel = new Panel();
            if (@this.Hue != null)
                @this.Color.SetHue(@this.Hue.val);
            else
                @this.Color.Hue = 0;
            if (@this.Saturation != null)
                @this.Color.SetSaturation(@this.Saturation.val);
            else
                @this.Color.Saturation = 0;
            if (@this.Luminance != null)
                @this.Color.SetLuminosity(@this.Luminance.val);
            else
                @this.Color.Luminosity = 0;
            panel.BackColor = @this.Color.ToRgb();
            panel.Click += panel_Click;
            panel.Height = 18;
            return panel;

            void panel_Click(object sender, EventArgs e)
            {
                using (var cd = new ColorDialog())
                {
                    cd.Color = @this.Color.ToRgb();
                    if (cd.ShowDialog() == DialogResult.OK)
                    {
                        @this.Color = HslColor.FromRgb(cd.Color);
                        //TODO: Check if this can cause error! Sometimes the file breaks if we add the missing value. Needs more checks.
                        /*if (((CUInt16)this.GetVariableByName("hue")) == null)
                            cr2w.CreateVariable( "CUInt16", "hue");
                        if (((CInt8)this.GetVariableByName("saturation")) == null)
                            cr2w.CreateVariable("CInt8", "saturation");
                        if (((CInt8)this.GetVariableByName("luminance")) == null)
                            cr2w.CreateVariable("CInt8", "luminance");*/
                        if (@this.Hue != null)
                            @this.Hue.val = (ushort)@this.Color.GetHue();
                        if (@this.Saturation != null)
                            @this.Saturation.val = (sbyte)@this.Color.GetSaturation();
                        if (@this.Luminance != null)
                            @this.Luminance.val = (sbyte)@this.Color.GetLuminosity();
                    }
                    ((Panel)sender).BackColor = @this.Color.ToRgb();
                }
            }
        }
        private static Control GetEditor(this CColor @this)
        {
            var panel = new Panel();
            panel.BackColor = System.Drawing.Color.FromArgb(@this.Red.val, @this.Green.val, @this.Blue.val);
            panel.Click += panel_Click;
            panel.Height = 18;
            return panel;

            void panel_Click(object sender, EventArgs e)
            {
                var dlg = new ColorDialog();
                dlg.Color = @this.Color;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    @this.Red.val = dlg.Color.R;
                    @this.Green.val = dlg.Color.G;
                    @this.Blue.val = dlg.Color.B;

                    ((Panel)sender).BackColor = dlg.Color;
                }
            }
        }
        private static Control GetEditor(this CXml @this)
        {
            var editor = new Panel();
            var exportbutton = new Button();
            exportbutton.Text = "Export";
            exportbutton.Click += (sender, args) =>
            {
                using (var sf = new SaveFileDialog()
                {
                    Filter = "XML Files | *.xml",
                    Title = "Select a place to save the xml file!"
                })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        @this.Data.Save(sf.FileName);
                    }
                }
            };
            editor.Controls.Add(exportbutton);
            var importbutton = new Button();
            exportbutton.Text = "Import";
            exportbutton.Click += (sender, args) =>
            {
                using (var of = new OpenFileDialog()
                {
                    Filter = "XML Files | *.xml",
                    Title = "Please select the file you would like to import!"
                })
                {
                    if (of.ShowDialog() == DialogResult.OK)
                    {
                        @this.Data = new XDocument(File.ReadAllText(of.FileName));
                    }
                }
            };
            editor.Controls.Add(exportbutton);
            editor.PerformLayout();
            return editor;
        }
    }

    public class PtrComboItem
    {
        public CR2WExportWrapper Value { get; set; }
        public string Text { get; set; }

        public override string ToString() => Text;
    }
}
