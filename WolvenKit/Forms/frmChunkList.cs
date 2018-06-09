using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.CR2W.Editors;

namespace WolvenKit
{
    public partial class frmChunkList : DockContent
    {
        private CR2WFile file;

        public frmChunkList()
        {
            InitializeComponent();
            limitTB.Enabled = limitCB.Checked;
            listView.ItemSelectionChanged += chunkListView_ItemSelectionChanged;
        }

        public CR2WFile File
        {
            get { return file; }
            set
            {
                file = value;
                updateList();
            }
        }

        public event EventHandler<SelectChunkArgs> OnSelectChunk;

        private void updateList(string keyword = "")
        {
            var limit = -1;
            if(limitCB.Checked)
            {
                int.TryParse(limitTB.Text,out limit);
            }
            if (File == null)
                return;
            if(!string.IsNullOrEmpty(keyword))
            {
                if(limit != -1)
                    listView.Objects = File.chunks.Where(x => x.Name.ToUpper().Contains(searchTB.Text.ToUpper())).Take(limit);
                else
                    listView.Objects = File.chunks.Where(x => x.Name.ToUpper().Contains(searchTB.Text.ToUpper()));
            }
            else
            {
                listView.Objects = File.chunks;
            }
        }

        private void chunkListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (OnSelectChunk != null && (CR2WChunk) listView.SelectedObject != null)
            {
                OnSelectChunk(this, new SelectChunkArgs {Chunk = (CR2WChunk) listView.SelectedObject});
            }
        }

        private void addChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new frmAddChunk();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var chunk = File.CreateChunk(dlg.ChunkType);
                    listView.AddObject(chunk);

                    if (OnSelectChunk != null && chunk != null)
                    {
                        OnSelectChunk(this, new SelectChunkArgs {Chunk = chunk});
                    }
                }
                catch (InvalidChunkTypeException ex)
                {
                    MessageBox.Show(ex.Message, "Error adding chunk.");
                }
            }
        }

        private void deleteChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedObjects.Count == 0)
                return;

            if (MessageBox.Show("Are you sure you want to delete the selected chunk(s)? \n\n NOTE: Any pointers or handles to these chunks will NOT be deleted.","Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var selected = listView.SelectedObjects;
                foreach (var obj in selected)
                {
                    File.RemoveChunk((CR2WChunk) obj);
                }

                listView.RemoveObjects(selected);
                listView.UpdateObjects(File.chunks);
            }
        }

        private void copyChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            var chunks = listView.SelectedObjects.Cast<CR2WChunk>().ToList();
            CopyController.ChunkList = chunks;
            pasteChunkToolStripMenuItem.Enabled = true;
        }

        private void pasteChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var copiedchunks = CopyController.ChunkList;
            if (copiedchunks != null && copiedchunks.Count > 0)
            {
                foreach (var chunk in copiedchunks)
                {
                    try
                    {
                        var pastedchunk = CR2WCopyAction.CopyChunk(chunk, chunk.CR2WOwner);
                        listView.AddObject(pastedchunk);
                        OnSelectChunk?.Invoke(this, new SelectChunkArgs { Chunk = pastedchunk });
                        MainController.Get().ProjectStatus = "Chunk copied";
                    }
                    catch (InvalidChunkTypeException ex)
                    {
                        MessageBox.Show(ex.Message, @"Error adding chunk.");
                    }
                }
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            updateList(searchTB.Text);
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            updateList();
        }

        private void limitCB_CheckStateChanged(object sender, EventArgs e)
        {
            limitTB.Enabled = limitCB.Checked;
        }

        private void searchTB_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (int)Keys.Enter)
                updateList(searchTB.Text);
        }

        private void listView_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            MainController.Get().ProjectUnsaved = true;
        }

        private void addChunksFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO check if file is w2l
           
            var w2lLoader = new w2lChunkAdder();
            List<w2lAdderData> ChunksList = new List<w2lAdderData>();

            //See if the base class has an entities array
            List<IEditableVariable> variablesList = new List<IEditableVariable>();
            int idx = -1;
            variablesList = File.chunks[0].data.GetEditableVariables();
            for (int j = 0; j < variablesList.Count; j++)
            {
                if (variablesList[j].Name == "entities")
                {
                    idx = j;
                }
            }
            if (idx == -1)
            {
                MessageBox.Show("Please add an entities array to the layer!", "Error adding chunks.");
                return;
            }

            //read file and store in w2lAdderData class
            ChunksList = w2lLoader.ReadFile(File);
           

            //adds chunks to chunks list
            for (int i = 0; i < ChunksList.Count; i++)
            {
                try
                {
                    //Add Chunk
                    var chunk = File.CreateChunk(ChunksList[i].chunkType, File.chunks[0]); //adds chunk and sets first chunk as parent
                    listView.AddObject(chunk);

                    //Add Variables to Chunk
                    chunk.data.AddVariable(ChunksList[i].transform);
                    chunk.data.AddVariable(ChunksList[i].template);

                    //Add a reference to the base class (chunk 0)
                    var newptr = new CPtr(File);
                    newptr.ChunkIndex = chunk.ChunkIndex;
                    File.chunks[0].data.GetEditableVariables()[idx].AddVariable(newptr);

                }
                catch (InvalidChunkTypeException ex)
                {
                    MessageBox.Show(ex.Message, "Error adding chunk.");
                }

                
            }


        }
    }
}