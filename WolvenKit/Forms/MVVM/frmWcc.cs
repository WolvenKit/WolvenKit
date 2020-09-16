using BrightIdeasSoftware;
using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.App.Commands;
using WolvenKit.App.ViewModels;
using WolvenKit.Common.Wcc;
using WolvenKit.CR2W.Types;
using WolvenKit.Services;

namespace WolvenKit.Forms.MVVM
{
    

    public partial class frmWcc : DockContent, IThemedContent
    {
        private readonly ModkitViewModel viewModel;

        public frmWcc()
        {
            viewModel = MockKernel.Get().GetModkitViewModel();
            viewModel.PropertyChanged += ViewModel_PropertyChanged;

            InitializeComponent();

            ApplyCustomTheme();

            objectListView.SetObjects(viewModel.Commands);
            propertyGrid.SelectedObject = viewModel.SelectedObject;

            this.Icon = new Icon(@"Resources\Icons\GUI\WCC_32x.ico", new Size(16,16));
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == nameof(viewModel.ProgressReport))
            //{
                
            //}
        }

        public void ApplyCustomTheme()
        {
            UIController.Get().ToolStripExtender.SetStyle(toolStrip, VisualStudioToolStripExtender.VsVersion.Vs2015, UIController.GetTheme());

            Color background = UIController.GetBackColor();
            Color highlight = UIController.GetHighlightColor();
            Color textStyle = UIController.GetForeColor();

            // objectlistview
            this.objectListView.BackColor = background;
            this.objectListView.ForeColor = textStyle;
            this.objectListView.HeaderFormatStyle = UIController.GetHeaderFormatStyle();
            objectListView.UnfocusedSelectedBackColor = UIController.GetPalette().CommandBarToolbarButtonPressed.Background;

            // textbox
            textBoxArgs.BackColor = background;
            textBoxArgs.ForeColor = UIController.GetPalette().DockTarget.GlyphArrow;

            // propertygrid
            // backgrounds
            propertyGrid.HelpBackColor = background;
            propertyGrid.ViewBackColor = background;
            propertyGrid.HelpForeColor = textStyle;
            propertyGrid.ViewForeColor = textStyle;
            propertyGrid.CategoryForeColor = textStyle;
            // highlighted
            propertyGrid.BackColor = highlight;
            propertyGrid.CategorySplitterColor = highlight;
            propertyGrid.LineColor = highlight;


            // split containers
            splitContainer1.BackColor = highlight;
            splitContainer2.BackColor = highlight;

        }

        private void toolStripButtonRun_Click(object sender, EventArgs e) => viewModel.RunCommand.SafeExecute();

        private void objectListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedItem = (WCC_Command)objectListView.SelectedObject;
            if (selectedItem != null)
            {
                viewModel.SelectedObject = selectedItem;
                propertyGrid.SelectedObject = viewModel.SelectedObject;
            }
            UpdateCommandLine();
        }

        private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            UpdateCommandLine();
        }

        private void UpdateCommandLine()
        {

            textBoxArgs.Text = ((WCC_Command)propertyGrid.SelectedObject).Arguments;
            textBoxArgs.Update();
        }

        #region Propertygrid Drag and Drop
        private void propertyGrid_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        // https://social.msdn.microsoft.com/Forums/windows/en-US/d7fffb03-8ade-4b19-935a-368c96f3f557/drag-and-drop-to-propertygrid?forum=winforms
        private void propertyGrid_DragDrop(object sender, DragEventArgs e)
        {
            string path = "";
            if (e.Data is OLVDataObject oLVDataObject)
            {
                if (oLVDataObject.ModelObjects != null && oLVDataObject.ModelObjects.Count != 0)
                {
                    if (oLVDataObject.ModelObjects[0] is DirectoryInfo di)
                    {
                        path = di.FullName;
                    }
                    else if (oLVDataObject.ModelObjects[0] is FileSystemInfo fsi)
                    {
                        path = fsi.FullName;
                    }


                    var p = e.Data.GetData(typeof(string));
                    object propertyGridView = GetPropertyGridView(this.propertyGrid);



                    GridItemCollection allGridEntries = GetAllGridEntries(propertyGridView);

                    int top = GetTop(propertyGridView);
                    int itemHeight = GetCachedRowHeight(propertyGridView);

                    VScrollBar scrollBar = GetVScrollBar(propertyGridView);
                    GridItem item = GetItemAtPoint(allGridEntries, top, itemHeight, scrollBar.Value, this.propertyGrid.PointToClient(new Point(e.X, e.Y)));

                    if (item != null)
                    {
                        var a = item.PropertyDescriptor.Attributes.OfType<REDTags>().Cast<REDTags>().ToList();
                        if (a.Any())
                        {
                            if (a.First().tag.Contains("Path") && item.PropertyDescriptor.PropertyType == typeof(string))
                            {
                                item.PropertyDescriptor.SetValue(this.propertyGrid.SelectedObject, path);
                                this.propertyGrid.Refresh();
                                UpdateCommandLine();
                            }
                        }
                    }
                }
            }
        }

        object GetPropertyGridView(PropertyGrid propertyGrid)
        {
            foreach (Control c in propertyGrid.Controls)
            {
                if (c.GetType().Name == "PropertyGridView")
                    return c;
            }
            return null;
        }
        GridItemCollection GetAllGridEntries(object propertyGridView)
        {
            FieldInfo fi = propertyGridView.GetType().GetField("allGridEntries", BindingFlags.NonPublic | BindingFlags.Instance);
            return (GridItemCollection)fi.GetValue(propertyGridView);
        }
        int GetTop(object propertyGridView)
        {
            Control ctrl = (Control)propertyGridView;
            return ctrl.Top;
        }
        int GetCachedRowHeight(object propertyGridView)
        {
            FieldInfo fi = propertyGridView.GetType().GetField("cachedRowHeight", BindingFlags.NonPublic | BindingFlags.Instance);
            return (int)fi.GetValue(propertyGridView);
        }
        VScrollBar GetVScrollBar(object propertyGridView)
        {
            FieldInfo fi = propertyGridView.GetType().GetField("scrollBar", BindingFlags.NonPublic | BindingFlags.Instance);
            return (VScrollBar)fi.GetValue(propertyGridView);
        }
        GridItem GetItemAtPoint(GridItemCollection items, int top, int itemHeight, int scrollItems, Point pt)
        {
            int idx = (pt.Y - top) / (itemHeight + 1);
            idx += scrollItems;
            if (items == null || items.Count < idx)
                return null;
            GridItem item = items[idx];
            return item;
        }
        #endregion
    }
}
