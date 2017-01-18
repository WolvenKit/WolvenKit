using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.CR2W;
using W3Edit.CR2W.Types;

namespace W3Edit.FlowTreeEditors
{
    public partial class ChunkEditor : UserControl
    {
        public virtual string GetCopyText() { return chunk.Name; }

        private CR2WChunk chunk;
        public CR2WChunk Chunk
        {
            get
            {
                return chunk;
            }
            set
            {
                chunk = value;
                UpdateView();
            }
        }

        private bool mouseMoving;
        private Point mouseStart;

        public event EventHandler<SelectChunkArgs> OnSelectChunk;
        public event EventHandler<MoveEditorArgs> OnManualMove;

        public ChunkEditor()
        {
            InitializeComponent();
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseStart = e.Location;
            mouseMoving = true;
        }

        private void lblTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseMoving = false;
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseMoving)
            {
                if (OnManualMove != null)
                {
                    OnManualMove(this, new MoveEditorArgs() {
                        Relative = new Point((Location.X - mouseStart.X + e.X) - Location.X, (Location.Y - mouseStart.Y + e.Y) - Location.Y) 
                    });
                }
                Location = new Point(Location.X - mouseStart.X + e.X, Location.Y - mouseStart.Y + e.Y);
            }
        }

        public virtual void UpdateView()
        {
            lblTitle.Text = chunk.Name;
            Height = lblTitle.Height;
        }

        public virtual List<CPtr> GetConnections()
        {
            return null;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            FireSelectEvent(Chunk);
        }

        private void ChunkEditor_Click(object sender, EventArgs e)
        {
            FireSelectEvent(Chunk);
        }

        public void FireSelectEvent(CR2WChunk c)
        {
            if (OnSelectChunk != null)
            {
                OnSelectChunk(this, new SelectChunkArgs() { Chunk = c });
            }
        }

        public virtual Point GetConnectionLocation(int i)
        {
            return new Point(0, Height / 2);
        }
    }
}
