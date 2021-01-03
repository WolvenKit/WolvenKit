using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Model;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.FlowTreeEditors;

namespace WolvenKit
{
    public partial class frmChunkFlowDiagram : DockContent
    {
        private readonly int connectionPointSize = 7;

        /// <summary>
        ///     Connecting
        /// </summary>
        private readonly Pen connectionTargetColor;

        private readonly HashSet<ChunkEditor> selectedEditors;

        /// <summary>
        ///     Selection
        /// </summary>
        private readonly Brush selectionBackground;

        private readonly Pen selectionBorder;
        private readonly Pen selectionItemHighlight;
        private readonly Brush selectionItemHighlightBrush;
        private IPtrAccessor connectingSource;
        private ChunkEditor connectingSourceEditor;
        private int connectingSourceIndex;
        private ChunkEditor connectingTarget;
        private Dictionary<int, List<ChunkEditor>> EditorLayout;
        public ChunkEditor EditorUnderCursor;
        private CR2WFile file;
        private bool isConnecting;
        private bool isSelecting;
        private bool isMoving;
        private Point prevMousePos;
        private int maxdepth;
        private Point selectionEnd;
        private Point selectionStart;
        public float zoom = 100;

        public frmChunkFlowDiagram()
        {
            InitializeComponent();

            selectionBackground = new SolidBrush(Color.FromArgb(100, SystemColors.Highlight));
            selectionBorder = new Pen(Color.FromArgb(200, SystemColors.Highlight));
            selectionItemHighlight = new Pen(Color.Green, 2.0f);
            selectionItemHighlightBrush = new SolidBrush(Color.Green);
            selectedEditors = new HashSet<ChunkEditor>();
            connectionTargetColor = new Pen(Color.Red, 2.0f);
        }

        public CR2WFile File
        {
            get { return file; }
            set
            {
                file = value;
                createChunkEditors();
            }
        }

        public Dictionary<CR2WExportWrapper, ChunkEditor> ChunkEditors { get; set; }
        public event EventHandler<SelectChunkArgs> OnSelectChunk;
        public event EventHandler<string> OnOutput;

        public void createChunkEditors()
        {
            if (File == null)
                return;

            ChunkEditors = new Dictionary<CR2WExportWrapper, ChunkEditor>();

            var rootNodes = new List<CR2WExportWrapper>();

            var activeRoot = File.Chunks[0];

            if (File != null && File.Chunks.Count > 0)
            {
                switch (activeRoot.REDType)
                {
                    case "CQuestPhase":
                        getQuestPhaseRootNodes(rootNodes);
                        break;
                    case "CQuest":
                        getQuestRootNodes(rootNodes);
                        break;
                    case "CStoryScene":
                        getStorySceneRootNodes(rootNodes);
                        break;
                    default:
                        break;
                }
            }


            EditorLayout = new Dictionary<int, List<ChunkEditor>>();

            foreach (var c in rootNodes)
            {
                createEditor(0, c);
            }

            int x = 0;
            
            for (int i = 0; i <= maxdepth; i++) {
                var y = 0;
                
                if (EditorLayout.ContainsKey(i)) {
                    int widestEditor = 0;
                    foreach (var ls in EditorLayout[i])
                    {
                        ls.Location = new Point(x, y);
                        y += ls.Height + 15;
                        widestEditor = Math.Max(widestEditor, ls.Width);
                    }

                    x += widestEditor + 50;
                }
            }

        

            var maxwidth = 0;
            var maxheight = 0;
            foreach (Control c in Controls)
            {
                if (maxwidth < c.Location.X + c.Width)
                    maxwidth = c.Location.X + c.Width;
                if (maxheight < c.Location.Y + c.Height)
                    maxheight = c.Location.Y + c.Height;
            }

            //AutoScrollMinSize = new Size(this.Width, this.Height);
        }


        private void createEditor(int depth, CR2WExportWrapper c)
        {
            try {
                if (ChunkEditors.ContainsKey(c))
                    return;

                var editor = GetEditor(c);
                editor.Chunk = c;
                editor.OnSelectChunk += editor_OnSelectChunk;
                editor.OnManualMove += editor_OnMove;
                editor.LocationChanged += editor_LocationChanged;
                editor.OriginalSize = editor.Size;
                Controls.Add(editor);
                ChunkEditors.Add(c, editor);

                if (depth > maxdepth)
                    maxdepth = depth;

                if (!EditorLayout.ContainsKey(depth))
                    EditorLayout.Add(depth, new List<ChunkEditor>());

                EditorLayout[depth].Add(editor);

                var conns = editor.GetConnections();
                if (conns != null) {
                    foreach (var conn in conns) {
                        if (conn.Reference != null) {
                            createEditor(depth + 1, conn.Reference);
                        }
                    }
                }
            }
            catch (Exception e) {
                OnOutput.Invoke(this, e.ToString());
            }
        }

        private void editor_LocationChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void editor_OnMove(object sender, MoveEditorArgs e)
        {
            if (selectedEditors.Contains(sender))
            {
                foreach (var c in selectedEditors.Where(c => c != sender))
                {
                    c.Location = new Point(c.Location.X + e.Relative.X, c.Location.Y + e.Relative.Y);
                }
            }
            //Invalidate();
            Refresh();
        }

        private void editor_OnSelectChunk(object sender, SelectChunkArgs e)
        {
            OnSelectChunk?.Invoke(sender, e);
        }

        private void getStorySceneRootNodes(List<CR2WExportWrapper> rootNodes)
        {
            CStoryScene resource = (CStoryScene)File.Chunks[0].data;
            CArray<CPtr<CStorySceneControlPart>> controlParts = resource.ControlParts;
            if (controlParts != null)
            {
                rootNodes.AddRange(from part in controlParts.Elements.OfType<CPtr<CStorySceneControlPart>>() where part != null && part.GetPtrTargetType() == "CStorySceneInput" select part.Reference); ;
            }
        }

        private void getQuestPhaseRootNodes(List<CR2WExportWrapper> rootNodes)
        {
            CQuestPhase resource = (CQuestPhase)File.Chunks[0].data;
            CPtr<CQuestGraph> graphObj = resource.Graph;
            if (graphObj != null)
            {
                var graphBlocks = (graphObj.Reference.data as CQuestGraph).GraphBlocks;
                if (graphBlocks != null)
                {
                    rootNodes.AddRange(from part in graphBlocks.Elements.OfType<CPtr<CGraphBlock>>() where part != null && part.GetPtrTargetType() == "CQuestPhaseInputBlock" select part.Reference);
                }
            }
        }

        private void getQuestRootNodes(List<CR2WExportWrapper> rootNodes)
        {
            CQuest quest = (CQuest)File.Chunks[0].data;
            CPtr<CQuestGraph> graphObj = quest.Graph;
            if (graphObj != null)
            {
                CArray<CPtr<CGraphBlock>> graphBlocks = (graphObj.Reference.data as CQuestGraph).GraphBlocks;
                if (graphBlocks != null)
                {
                    rootNodes.AddRange(from part in graphBlocks.Elements.OfType<CPtr<CGraphBlock>>() where part != null && part.GetPtrTargetType() == "CQuestStartBlock" select part.Reference);
                }
            }


        }

        public ChunkEditor GetEditor(CR2WExportWrapper c)
        {
            if (c.data is CStorySceneSection)
                return new SceneSectionEditor();

            switch (c.REDType)
            {
                // quest
                
                case "CQuestPhaseBlock":
                    return new QuestPhaseEditor();
                case "CQuestScriptBlock":
                    return new QuestScriptEditor();
                
                // story
                
                case "CStorySceneChoice":
                    return new SceneChoiceEditor();
                case "CStorySceneFlowCondition":
                    return new SceneFlowConditionEditor();
                case "CStorySceneRandomizer":
                    return new SceneRandomizerEditor();
                default:
                    // should support both quests and scenes
                    return new QuestLinkEditor();
            }
        }

        private void frmChunkFlowView_Paint(object sender, PaintEventArgs e)
        {
            foreach (var c in ChunkEditors.Values)
            {
                bool editorSelected = selectedEditors.Contains(c);

                var brush = editorSelected ? selectionItemHighlightBrush : Brushes.Black;
                var pen = editorSelected ? selectionItemHighlight : Pens.Black;

                var i = 0;
                List<IPtrAccessor> conns = null;

                try {
                    conns = c.GetConnections();
                }
                catch (Exception) {
                    // eat the exception, allready logging the exception when creating the node editor
                }

                if (conns != null)
                {
                    foreach (var conn in conns)
                    {
                        if (ChunkEditors.ContainsKey(conn.Reference))
                        {
                            var c2 = ChunkEditors[conn.Reference];
                            var sp = c.GetConnectionLocation(i);
                            e.Graphics.FillRectangle(brush, c.Location.X + c.Width,
                                c.Location.Y + sp.Y - connectionPointSize/2, connectionPointSize, connectionPointSize);

                            DrawConnectionBezier(e.Graphics, pen,
                                c.Location.X + c.Width + connectionPointSize, c.Location.Y + sp.Y,
                                c2.Location.X, c2.Location.Y + c2.Height/2
                                );
                        }
                        i++;
                    }
                }

                if (editorSelected)
                {
                    e.Graphics.DrawRectangle(selectionItemHighlight,
                        c.Location.X - 1,
                        c.Location.Y - 1,
                        c.Width + 2,
                        c.Height + 2);
                }
            }

            if (isSelecting)
            {
                var x = selectionStart.X < selectionEnd.X ? selectionStart.X : selectionEnd.X;
                var y = selectionStart.Y < selectionEnd.Y ? selectionStart.Y : selectionEnd.Y;
                var w = Math.Abs(selectionStart.X - selectionEnd.X);
                var h = Math.Abs(selectionStart.Y - selectionEnd.Y);

                var rect = new Rectangle(x, y, w, h);

                e.Graphics.FillRectangle(selectionBackground, rect);
                e.Graphics.DrawRectangle(selectionBorder, rect);
            }

            if (isConnecting)
            {
                var c = connectingSourceEditor;
                var sp = c.GetConnectionLocation(connectingSourceIndex);

                if (connectingTarget != null)
                {
                    var rect = new Rectangle(connectingTarget.Location.X - 1, connectingTarget.Location.Y - 1,
                        connectingTarget.Width + 2, connectingTarget.Height + 2);

                    e.Graphics.DrawRectangle(connectionTargetColor, rect);

                    DrawConnectionBezier(e.Graphics, connectionTargetColor,
                        c.Location.X + c.Width + connectionPointSize, c.Location.Y + sp.Y,
                        connectingTarget.Location.X, connectingTarget.Location.Y + connectingTarget.Height/2
                        );
                }
                else
                {
                    DrawConnectionBezier(e.Graphics, connectionTargetColor,
                        c.Location.X + c.Width + connectionPointSize, c.Location.Y + sp.Y,
                        selectionEnd.X, selectionEnd.Y
                        );
                }
            }
        }

        private static void DrawConnectionBezier(Graphics g, Pen c, int x1, int y1, int x2, int y2)
        {
            var yoffset = 0;
            var xoffset = Math.Max(Math.Min(Math.Abs(x1 - x2)/2, 200), 50);
            g.DrawBezier(c,
                x1, y1,
                x1 + xoffset, y1 + yoffset,
                x2 - xoffset, y2 - yoffset,
                x2, y2);
        }

        private void frmChunkFlowDiagram_Scroll(object sender, MouseEventArgs e)
        {
            float prevZoom = zoom;
            if(e.Delta > 0)
                zoom += 7;
            else
                zoom -= 7;
            if (zoom < 23)
                zoom = 23;
            foreach (ChunkEditor c in Controls)
            {
                c.Size = new Size((int)(c.OriginalSize.Width * zoom / 100), (int)(c.OriginalSize.Height * zoom / 100));
                c.Left = (int)Math.Round(c.Left * zoom / prevZoom);
                c.Top = (int)Math.Round(c.Top* zoom / prevZoom);
            }
            Invalidate();
        }

        private void frmChunkFlowDiagram_KeyDown(object sender, KeyEventArgs e)
        {
            Invalidate();
        }

        private void frmChunkFlowDiagram_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Form.ModifierKeys != Keys.Control)
                {
                    foreach (var c in ChunkEditors.Values)
                    {
                        var conns = c.GetConnections();
                        if (conns != null)
                        {
                            for (var i = 0; i < conns.Count; i++)
                            {
                                var sp = c.GetConnectionLocation(i);

                                var rect = new Rectangle(c.Location.X + c.Width, c.Location.Y + sp.Y - connectionPointSize / 2,
                                    connectionPointSize, connectionPointSize);
                                if (rect.Contains(e.Location))
                                {
                                    connectingSource = conns[i];
                                    connectingSourceEditor = c;
                                    connectingSourceIndex = i;
                                    isConnecting = true;
                                    return;
                                }
                            }
                        }
                    }

                    selectionStart = e.Location;
                    isSelecting = true;
                }
                else
                {
                    prevMousePos = e.Location;
                    isMoving = true;
                }
            }
        }

        private void frmChunkFlowDiagram_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                selectionEnd = e.Location;

                SelectChunks();

                Invalidate();
            }

            if (isConnecting)
            {
                selectionEnd = e.Location;

                CheckConnectTarget();

                Invalidate();
            }

            if (isMoving)
            {
                foreach(Control c in Controls)
                {
                    c.Left -= prevMousePos.X - e.Location.X;
                    c.Top -= prevMousePos.Y - e.Location.Y;
                }

                Invalidate();
            }
            prevMousePos = e.Location;
        }

        private void CheckConnectTarget()
        {
            connectingTarget = null;

            foreach (var c in ChunkEditors.Values)
            {
                var r = new Rectangle(c.Location, c.Size);
                if (r.Contains(selectionEnd.X, selectionEnd.Y))
                {
                    connectingTarget = c;
                    break;
                }
            }
        }

        private void frmChunkFlowDiagram_MouseUp(object sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                selectionEnd = e.Location;
                isSelecting = false;
                SelectChunks();
                Invalidate();
            }

            if (isConnecting)
            {
                selectionEnd = e.Location;
                isConnecting = false;

                DoConnect();

                Invalidate();
            }

            if (isMoving)
            {
                isMoving = false;

                Invalidate();
            }
        }

        private void DoConnect()
        {
            if (connectingTarget != null)
            {
                connectingSource.Reference = connectingTarget.Chunk;
            }
        }

        private void SelectChunks()
        {
            selectedEditors.Clear();

            var x = selectionStart.X < selectionEnd.X ? selectionStart.X : selectionEnd.X;
            var y = selectionStart.Y < selectionEnd.Y ? selectionStart.Y : selectionEnd.Y;
            var w = Math.Abs(selectionStart.X - selectionEnd.X);
            var h = Math.Abs(selectionStart.Y - selectionEnd.Y);

            var rect = new Rectangle(x, y, w, h);

            foreach (var c in from c in ChunkEditors.Values let r = new Rectangle(c.Location, c.Size) where rect.IntersectsWith(r) select c)
            {
                selectedEditors.Add(c);
            }
        }

        protected override Point ScrollToControl(Control activeControl)
        {
            return AutoScrollPosition;
        }

        private void frmChunkFlowDiagram_Load(object sender, EventArgs e)
        {
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            EditorUnderCursor = null;
            foreach (var c in ChunkEditors.Values)
            {
                var r = new Rectangle(PointToScreen(c.Location), c.Size);
                if (r.Contains(contextMenuStrip1.Left, contextMenuStrip1.Top))
                {
                    EditorUnderCursor = c;
                    break;
                }
            }

            copyToolStripMenuItem.Enabled = selectedEditors.Count > 0 || EditorUnderCursor != null;
            copyDisplayTextToolStripMenuItem.Enabled = selectedEditors.Count > 0 || EditorUnderCursor != null;
            //pasteToolStripMenuItem.Enabled = ;
        }

        private void copyDisplayTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var text = new StringBuilder();

            if (selectedEditors.Count == 0)
            {
                var editor = EditorUnderCursor;
                if (editor != null)
                {
                    text.AppendLine(editor.GetCopyText());
                }
            }
            else
            {
                foreach (var editor in selectedEditors)
                {
                    text.AppendLine(editor.GetCopyText());
                }
            }

            if (text.Length > 0)
            {
                Clipboard.SetText(text.ToString());
            }
        }
    }
}