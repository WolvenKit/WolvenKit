using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.CR2W;
using WeifenLuo.WinFormsUI.Docking;

namespace W3Edit
{
    public partial class frmChunkList : DockContent
    {
        private CR2WFile file;
        public CR2WFile File { 
            get { return file; } 
            set { file = value; updateList(); } 
        }
        public event EventHandler<SelectChunkArgs> OnSelectChunk;

        public frmChunkList()
        {
            InitializeComponent();

            listView.ItemSelectionChanged += chunkListView_ItemSelectionChanged;
        }

        private void updateList()
        {
            if (File == null)
                return;

            listView.Objects = File.chunks;
        }

        private void chunkListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (OnSelectChunk != null && (CR2WChunk)listView.SelectedObject != null)
            {
                OnSelectChunk(this, new SelectChunkArgs() { Chunk = (CR2WChunk)listView.SelectedObject });
            }
        }

        private void addChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new frmAddChunk();

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var chunk = File.CreateChunk(dlg.ChunkType);
                    listView.AddObject(chunk);

                    if (OnSelectChunk != null && chunk != null)
                    {
                        OnSelectChunk(this, new SelectChunkArgs() { Chunk = chunk });
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

            if (MessageBox.Show("Are you sure you want to delete the selected chunk(s)? \n\n NOTE: Any pointers or handles to these chunks will NOT be deleted.", "Confirmation", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                var selected = listView.SelectedObjects;
                foreach (var obj in selected)
                {
                    File.RemoveChunk((CR2WChunk)obj);
                }

                listView.RemoveObjects(selected);
                listView.UpdateObjects(File.chunks);
            }
        }

        private void copyChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            List<CR2WChunk> chunks = new List<CR2WChunk>();
            foreach (CR2WChunk item in listView.SelectedObjects)
                chunks.Add(item);
            CopyController.ChunkList = chunks;
            pasteChunkToolStripMenuItem.Enabled = true;
        }

        private void pasteChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var copiedchunks = CopyController.ChunkList;
            if(copiedchunks != null && copiedchunks.Count > 0)
            {
                foreach (CR2WChunk chunk in copiedchunks)
                {
                    try
                    {
                        var pastedchunk = File.CreateChunk(chunk.Type, chunk.data, chunk.Parent);
                        listView.AddObject(pastedchunk);
                        if (OnSelectChunk != null && chunk != null)
                        {
                            OnSelectChunk(this, new SelectChunkArgs() { Chunk = chunk });
                        }
                        listView.RefreshObject(pastedchunk);
                    }
                    catch (InvalidChunkTypeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error adding chunk.");
                    }   
                }             
            }
        }
    }
}
