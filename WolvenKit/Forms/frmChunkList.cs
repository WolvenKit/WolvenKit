using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.CR2W;

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
            if (limitCB.Checked)
            {
                int.TryParse(limitTB.Text, out limit);
            }
            if (File == null)
                return;
            if (!string.IsNullOrEmpty(keyword))
            {
                if (limit != -1)
                    listView.Objects = File.chunks.Where(x => x.Name.ToUpper().Contains(searchTB.Text.ToUpper())).Take(limit);
                else
                    listView.Objects = File.chunks.Where(x => x.Name.ToUpper().Contains(searchTB.Text.ToUpper()));
            }
            else
            {
                listView.Objects = File.chunks;
            }
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            pasteChunkToolStripMenuItem.Enabled = CopyController.ChunkList != null && CopyController.ChunkList.Count > 0;
        }

        private void chunkListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (OnSelectChunk != null && (CR2WChunk)listView.SelectedObject != null)
            {
                OnSelectChunk(this, new SelectChunkArgs { Chunk = (CR2WChunk)listView.SelectedObject });
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
                        OnSelectChunk(this, new SelectChunkArgs { Chunk = chunk });
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

            if (MessageBox.Show("Are you sure you want to delete the selected chunk(s)? \n\n NOTE: Any pointers or handles to these chunks will NOT be deleted.", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
            CopyChunks();
        }

        public void CopyChunks()
        {
            Clipboard.Clear();
            var chunks = listView.SelectedObjects.Cast<CR2WChunk>().ToList();
            CopyController.ChunkList = chunks;
        }

        private void pasteChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteChunks();
        }

        public void PasteChunks()
        {
            var copiedchunks = CopyController.ChunkList;
            if (copiedchunks != null && copiedchunks.Count > 0)
            {
                foreach (var chunk in copiedchunks)
                {
                    try
                    {
                        var pastedchunk = CR2WCopyAction.CopyChunk(chunk, file);
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
            if (e.KeyValue == (int)Keys.Enter)
                updateList(searchTB.Text);
        }

        private void listView_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            MainController.Get().ProjectUnsaved = true;
        }
    }
}