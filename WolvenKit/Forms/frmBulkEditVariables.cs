using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Forms
{
   

    public partial class frmBulkEditVariables : Form
    {
        private enum Status
        {
            remove = 0,
            add = 1,
            edit = 2
        };

        private class SBulkEditVariable
        {
            //public CVariable var;

            public string name;
            public string type;
            public float value; //FIXME 

            public Status status;

            public string key;
           
        }


        
        
        List<SBulkEditVariable> AllVariables = new List<SBulkEditVariable>();

        //initialize
        public frmBulkEditVariables()
        {
            InitializeComponent();

            
            var mng = CR2WTypeManager.Get();
            var types = mng.AvailableTypes;
            types.Sort();
            cmbBoxVarType.Items.AddRange(types.ToArray());

            cmbBoxVarType.Enabled = false;
            txtBoxVarName.Enabled = false;
            txtBoxVarValue.Enabled = false;

            var allfiles = MainController.Get().ActiveMod.Files;
            checkedListBoxFiles.Items.AddRange(allfiles.ToArray());

            var extensions = new List<string>();
            foreach (var file in allfiles.Where(file => !extensions.Contains(file.Split('.').Last())))
            {
                extensions.Add(file.Split('.').Last());
            }
            extensions.Add("(none)");
            extensions.Sort();
            ExtensionToolStripComboBox.Items.AddRange(extensions.ToArray());
        }



        private void frmBulkEditVariables_Load(object sender, EventArgs e)
        {

        }




        #region TREEVIEW
        //context menu - add top level node
        private void addNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode newNode = AddNewChunk();
            if (newNode != null)
            {
                VariableListTreeView.SelectedNode = VariableListTreeView.Nodes.Find(newNode.Name, true)[0];
            }
            
        }
        private TreeNode AddNewChunk()
        {
            //open form
            var frm = new frmAddChunk();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                return null;
            }
            string type = frm.ChunkType;

            //new node
            var newNode = new TreeNode
            {
                Text = type,
                Name = type
            };
            if (VariableListTreeView.Nodes.ContainsKey(type))
            {
                return null;
            }
            VariableListTreeView.Nodes.Add(newNode);

            //hook up class
            var newVar = new SBulkEditVariable
            {
                key = type,
                status = Status.remove, //default remove
                name = type,
                type = type
            };
            AllVariables.Add(newVar);

            return newNode;
        }

        //context menu - add Child node to selected node
        private void addChildNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VariableListTreeView.SelectedNode == null)
            {
                return;
            }
            TreeNode newNode = CreateNewNodeAndVariable(VariableListTreeView.SelectedNode);
            if (newNode != null)
            {
                VariableListTreeView.SelectedNode = VariableListTreeView.Nodes.Find(newNode.Name, true)[0];
            }
        }
        private TreeNode CreateNewNodeAndVariable(TreeNode node)
        {
            //open form
            var frm = new frmAddVariable();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                return null;
            }
            string varName = frm.VariableName;
            string varType = frm.VariableType;
            string varKey = GenerateKey(node, frm.VariableName);

            //new node
            var newNode = new TreeNode
            {
                Text = varType + ":" + varName,
                Name = varKey
            };
            if (node.Nodes.ContainsKey(varKey))
            {
                return null;
            }
            node.Nodes.Add(newNode);

            //hook up class
            var newVar = new SBulkEditVariable
            {
                key = varKey,
                status = Status.remove, //default remove
                name = varName,
                type = varType
            };
            AllVariables.Add(newVar);

            return newNode;
        }
       


        
        //click on node
        private void VariableListTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //open conetxt menu on right click
            if (e.Button == MouseButtons.Right)
            {
                VariableListTreeView.SelectedNode = e.Node;
                treeViewContextMenuStrip.Show(VariableListTreeView, e.Location);
            }

            //show details on left click
            if (e.Button == MouseButtons.Left)
            {
                VariableListTreeView_AfterSelect(this, new TreeViewEventArgs(e.Node));
            }
        }
        //select node
        private void VariableListTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            cmbBoxVarType.Enabled = true;
            txtBoxVarName.Enabled = true;
            txtBoxVarValue.Enabled = true;

            DisplayValuesForNode(e.Node);
            
        }
        private void DisplayValuesForNode(TreeNode node)
        {
            SBulkEditVariable var = GetVarFromNode(node);

            //MainController.Get().Window.AddOutput("var.key: " + var.key + " / var.type: " + var.type + "\n"); //dbg
            //MainController.Get().Window.AddOutput("node.name: " + node.Name + "\n"); //dbg

            txtBoxVarName.Text = var.name;
            cmbBoxVarType.Text = var.type;
            txtBoxVarValue.Text = var.value.ToString();
            switch (var.status)
            {
                case Status.remove:
                    rdbtnRemove.Checked = true;
                    break;
                case Status.add:
                    rdbtnAdd.Checked = true;
                    break;
                case Status.edit:
                    rdbtnEdit.Checked = true;
                    break;
                default:
                    break;
            }
        }

        //button apply
        private void btnVarDetailsApply_Click(object sender, EventArgs e)
        {
            TreeNode currentNode = VariableListTreeView.SelectedNode;
            SBulkEditVariable var = GetVarFromNode(currentNode);

            //CLASS
            //write to AllVars
            //FIXME check for change
            var.name = txtBoxVarName.Text;
            var.key = GenerateKey(currentNode.Parent, var.name);
            var.type = cmbBoxVarType.Text;
            var.value = float.Parse(txtBoxVarValue.Text);
            //FIXME
            if (rdbtnRemove.Checked)
            {
                var.status = Status.remove;
            }
            if (rdbtnAdd.Checked)
            {
                var.status = Status.add;
            }
            if (rdbtnEdit.Checked)
            {
                var.status = Status.edit;
            }

            //NODE
            //change displayed node key and text
            currentNode.Text = var.type + ":" + var.name;
            currentNode.Name = var.key;
            //change key for all children
            for (int i = 0; i < currentNode.Nodes.Count; i++)
            {
                SBulkEditVariable tempvar = GetVarFromNode(currentNode.Nodes[i]);
                currentNode.Nodes[i].Name = GenerateKey(currentNode.Nodes[i].Parent, tempvar.name);
                tempvar.key = currentNode.Nodes[i].Name;
            }
        }
        //button reset
        private void btnVarDetailsReset_Click(object sender, EventArgs e)
        {
            DisplayValuesForNode(VariableListTreeView.SelectedNode);
        }
       



       
        private string GenerateKey(TreeNode parent, string name)
        {
            string key = "";

            if (parent == null)
            {
                key = name;
            }
            else
            {
                key = parent.Name + "." + name;
            }

            return key;
        }
        
        private SBulkEditVariable GetVarFromNode(TreeNode node)
        {
            return AllVariables.Find(x => x.key.Equals(node.Name));
        }

        
        
        private void DeleteNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TreeNode currentNode = VariableListTreeView.SelectedNode;
            List<TreeNode> childnodes = new List<TreeNode>();
            childnodes = FindChildNodes(currentNode);
            //nodes
            VariableListTreeView.Nodes.Remove(VariableListTreeView.Nodes.Find(currentNode.Name, true)[0]);
            //variables
            foreach (TreeNode node in childnodes)
            {
                AllVariables.RemoveAll(x => x.key.Equals(node.Name)); //removes all child vars
            }
            AllVariables.RemoveAll(x => x.key.Equals(currentNode.Name)); //removes current var


        }
        


        private List<TreeNode> FindChildNodes(TreeNode parent)
        {
            List<TreeNode> childnodes  = new List<TreeNode>();
            foreach (TreeNode node in parent.Nodes)
            {
                childnodes.Add(node);
                childnodes.AddRange(FindChildNodes(node));
            }
            return childnodes;
        }
        #endregion




        #region FileList
        private List<string> activeFiles = new List<string>();
        //filter textbox changed text
        private void FilterToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            checkedListBoxFiles.BeginUpdate();
            checkedListBoxFiles.Items.Clear();

            string filterExtension = ExtensionToolStripComboBox.Text.ToString();
            string filterName = FilterToolStripTextBox.Text.ToString();
            UpdateFilteredFileList(MainController.Get().ActiveMod.Files, filterExtension, filterName);
            checkedListBoxFiles.Items.AddRange(activeFiles.ToArray());

            checkedListBoxFiles.EndUpdate();
        }
        //select extension
        private void ExtensionToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxFiles.BeginUpdate();
            checkedListBoxFiles.Items.Clear();

            string filterExtension = ExtensionToolStripComboBox.Text.ToString();
            string filterName = FilterToolStripTextBox.Text.ToString();
            UpdateFilteredFileList(MainController.Get().ActiveMod.Files, filterExtension, filterName);
            checkedListBoxFiles.Items.AddRange(activeFiles.ToArray());

            checkedListBoxFiles.EndUpdate();
        }
        //select all in selection
        private void SelectAllToolStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxFiles.Items.Count; i++)
            {
                checkedListBoxFiles.SetItemChecked(i, true);
            }

        }
        //unselect all in selection
        private void UnselectAllToolStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxFiles.Items.Count; i++)
            {
                checkedListBoxFiles.SetItemChecked(i, false);
            }
        }
        //clear filter
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            FilterToolStripTextBox.Text = "";

            //dbg
            /*checkedListBoxFiles.BeginUpdate();
            checkedListBoxFiles.Items.Clear();

            foreach (SBulkEditVariable item in AllVariables)
            {
                checkedListBoxFiles.Items.Add(item.key);
            }
           
            checkedListBoxFiles.EndUpdate();

            
            MainController.Get().Window.AddOutput(VariableListTreeView.SelectedNode.Level + "\n");*/
        }
        

        private void UpdateFilteredFileList(List<string> allitems, string extension, string name)
        {
            //FILTER LIST 1
            var filterList1 = new List<string>();
            
            if (!(string.IsNullOrEmpty(extension) || extension == "(none)"))
            {
                foreach (string str in allitems)
                {
                    if (str.Split('.').Last().Equals(extension))
                    {
                        filterList1.Add(str);
                    }
                }
            }
            else
                filterList1.AddRange(allitems);

            //FILTER LIST 2
            var filterList2 = new List<string>();

            if (!string.IsNullOrEmpty(name))
            {
                foreach (string str in allitems)
                {
                    if (str.Contains(name))
                    {
                        filterList2.Add(str);
                    }
                }
            }
            else
                filterList2.AddRange(allitems);

           activeFiles =  filterList1.Intersect(filterList2).ToList();
        }




        #endregion

        
        public void BulkEditVariables()
        {
            //Get all checked files in a list
            List<string> filesToEdit = new List<string>();
            filesToEdit.AddRange(checkedListBoxFiles.CheckedItems.OfType<string>().ToList());


            for (int i = 0; i < filesToEdit.Count; i++)
            {
                //open the file
                var fullpath = Path.Combine(MainController.Get().ActiveMod.FileDirectory, filesToEdit[i]);
                
                CR2WFile file;
                using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(fs))
                    {
                        file = new CR2WFile(reader)
                        {
                            FileName = fullpath,
                            EditorController = MainController.Get(),
                            LocalizedStringSource = MainController.Get()
                        };
                    }
                    fs.Close();
                }

                //remove variables
                List<TreeNode> variablesToEdit = new List<TreeNode>();
                foreach (TreeNode chunk in VariableListTreeView.Nodes)
                {
                    TreeNode lastNode = chunk.LastNode; //FIXME multiple nodes in one level
                    if (lastNode != null)
                        variablesToEdit.Add(lastNode);
                    //FIXME delete chunks?

                }

                for (int j = 0; j < variablesToEdit.Count; j++)
                {
                    //get list of parent variables for node in reverse order 
                    var variables = GetAllVarsForNode(variablesToEdit[j]);

                   
                    //get all chunks
                    var chunksToEdit = file.chunks.FindAll(x => (x.Type.Equals(variables[0].type)));
                    if (chunksToEdit == null)
                        return;

                    foreach (CR2WChunk chunk in chunksToEdit)
                    {
                        //get the first instance in chunk.data //FIXME this is safe, because I don't allow for chunk deletion
                        IEditableVariable varToEdit = chunk.data.GetEditableVariables().Find(x => (x.Name.Equals(variables[1].name) && x.Type.Equals(variables[1].type)));
                        if (varToEdit == null)
                            return;
                        //just chunk and variable
                        if (variables.Count == 2) 
                        {
                            chunk.data.RemoveVariable(varToEdit);
                            MainController.Get().Window.AddOutput("Removed one variable" + "\n");
                        }
                        else
                        {
                            //get to second to last var
                            for (int k = 2; k < variables.Count - 1; k++)
                            {
                                varToEdit = varToEdit.GetEditableVariables().Find(x => (x.Name.Equals(variables[k].name) && x.Type.Equals(variables[k].type)));
                            }
                            if (varToEdit == null)
                                return;
                            //remove last var from here
                            varToEdit.RemoveVariable(varToEdit.GetEditableVariables().Find(x => (x.Name.Equals(variables[variables.Count].name) && x.Type.Equals(variables[variables.Count].type))));

                            MainController.Get().Window.AddOutput("Removed one variable" + "\n");
                        }
                    }
                }

                //save
                using (var mem = new MemoryStream())
                {
                    using (var writer = new BinaryWriter(mem))
                    {
                        file.Write(writer);
                        mem.Seek(0, SeekOrigin.Begin);

                        using (var fs = new FileStream(file.FileName, FileMode.Create, FileAccess.Write)) //FILENAME
                        {
                            mem.WriteTo(fs);
                            fs.Close();
                        }
                    }
                }
            }


            //output done all
            MainController.Get().Window.AddOutput("Finished until: " + filesToEdit.Count + "\n");


        }

        private List<SBulkEditVariable> GetAllVarsForNode(TreeNode node)
        {
           var nodes = new List<TreeNode>();
            nodes.Add(node);
            for (int i = 0; i < node.Level; i++)
            {
                nodes.Add(nodes[i].Parent);
            }
            nodes.Reverse();

            var results = new List<SBulkEditVariable>();
            foreach (TreeNode item in nodes)
            {
               results.Add(GetVarFromNode(item));
            }
            return results;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            BulkEditVariables();
        }




        //MainController.Get().Window.AddOutput("select\n");
    }
}
