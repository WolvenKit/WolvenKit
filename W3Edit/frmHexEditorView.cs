using BrightIdeasSoftware;
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
using W3Edit.CR2W;
using W3Edit.CR2W.Editors;
using W3Edit.CR2W.Types;
using System.Collections;

namespace W3Edit
{
    public partial class frmHexEditorView : Form, IVirtualListDataSource 
    {
        public CR2WFile File { get; set; }

        private byte[] bytes;
        private byte[] readable;
        public byte[] Bytes
        {
            get { return bytes; }
            set { bytes = value; UpdateHex(); }
        }


        private List<VariableListNode> Root { get; set; }


        internal class HexListNode
        {
            private byte[] bytes;
            private byte[] readable;
            public int pos { get; set; }

            public string Position { 
                get { 
                    return pos.ToString("X8"); 
                } 
            }

            public string GetHex(int i)
            {
                if (pos + i < bytes.Length)
                    return bytes[pos + i].ToString("X2");
                return "";
            }

            public void SetHex(int i, string hex)
            {
                if (pos + i < bytes.Length)
                {
                    try
                    {
                        bytes[pos + i] = Convert.ToByte(hex, 16);
                        readable[pos + i] = bytes[i] > 31 && bytes[i] < 127 ? bytes[i] : (byte)'.';
                    }
                    catch
                    {

                    }
                }
            }

            public string Text
            {
                get
                {
                    return Encoding.Default.GetString(readable, pos, Math.Min(16, bytes.Length - pos));
                }
            }

            public string Hex00
            { 
                get 
                {
                    return GetHex(0);
                }
                set
                {
                    SetHex(0, value);
                }
            }

            public string Hex01
            {
                get
                {
                    return GetHex(1);
                }
                set
                {
                    SetHex(1, value);
                }
            }

            public string Hex02
            {
                get
                {
                    return GetHex(2);
                }
                set
                {
                    SetHex(2, value);
                }
            }

            public string Hex03
            {
                get
                {
                    return GetHex(3);
                }
                set
                {
                    SetHex(3, value);
                }
            }

            public string Hex04
            {
                get
                {
                    return GetHex(4);
                }
                set
                {
                    SetHex(4, value);
                }
            }

            public string Hex05
            {
                get
                {
                    return GetHex(5);
                }
                set
                {
                    SetHex(5, value);
                }
            }

            public string Hex06
            {
                get
                {
                    return GetHex(6);
                }
                set
                {
                    SetHex(6, value);
                }
            }

            public string Hex07
            {
                get
                {
                    return GetHex(7);
                }
                set
                {
                    SetHex(7, value);
                }
            }

            public string Hex08
            {
                get
                {
                    return GetHex(8);
                }
                set
                {
                    SetHex(8, value);
                }
            }

            public string Hex09
            {
                get
                {
                    return GetHex(9);
                }
                set
                {
                    SetHex(9, value);
                }
            }

            public string Hex0A
            {
                get
                {
                    return GetHex(10);
                }
                set
                {
                    SetHex(10, value);
                }
            }

            public string Hex0B
            {
                get
                {
                    return GetHex(11);
                }
                set
                {
                    SetHex(11, value);
                }
            }

            public string Hex0C
            {
                get
                {
                    return GetHex(12);
                }
                set
                {
                    SetHex(12, value);
                }
            }

            public string Hex0D
            {
                get
                {
                    return GetHex(13);
                }
                set
                {
                    SetHex(13, value);
                }
            }

            public string Hex0E
            {
                get
                {
                    return GetHex(14);
                }
                set
                {
                    SetHex(14, value);
                }
            }

            public string Hex0F
            {
                get
                {
                    return GetHex(15);
                }
                set
                {
                    SetHex(15, value);
                }
            }

            internal HexListNode(byte[] source, byte[] readable, int pos)
            {
                this.bytes = source;
                this.readable = readable;
                this.pos = pos;
            }
        }

        private List<HexListNode> HexRoot { get; set; }

        public frmHexEditorView()
        {
            InitializeComponent();

            Root = new List<VariableListNode>();


            treeView.CanExpandGetter = delegate(object x) { return ((VariableListNode)x).ChildCount > 0; };
            treeView.ChildrenGetter = delegate(object x) { return ((VariableListNode)x).Children; };
            treeView.Roots = Root;

            for (int i = 0; i < 16; i++)
            {
                var hexCol = new BrightIdeasSoftware.OLVColumn()
                {
                    Name = "colHex" + i.ToString("X2"),
                    Text = i.ToString("X2"),
                    AspectName = "Hex" + i.ToString("X2"),
                    Width = 30,
                    Sortable = false,
                    Searchable = false,
                    RendererDelegate = delegate(EventArgs e, Graphics g, Rectangle r, object rowObject)
                    {
                        var evt = ((DrawListViewSubItemEventArgs)e);
                        var index = evt.ColumnIndex-1;
                        var obj = (HexListNode)rowObject;
                        

                        if (obj.pos + index == bytestart)
                        {
                            g.FillRectangle(SystemBrushes.Highlight, r.X - 1, r.Y - 1, r.Width + 2, r.Height + 2);
                            g.DrawString(obj.GetHex(index), listView.Font, SystemBrushes.HighlightText, r.X + 3, r.Y + 2);
                        }
                        else
                        {
                            g.FillRectangle(SystemBrushes.Window, r.X - 1, r.Y - 1, r.Width + 2, r.Height + 2);
                            g.DrawString(obj.GetHex(index), listView.Font, SystemBrushes.WindowText, r.X + 3, r.Y + 2);
                        }

                        evt.DrawDefault = false;
                        return true;
                    },
                };
                listView.Columns.Add(hexCol);
            }

            listView.Columns.Add(new BrightIdeasSoftware.OLVColumn()
            {
                Name = "colText",
                Text = "Text",
                AspectName = "Text",
                HeaderFont = ((BrightIdeasSoftware.OLVColumn)listView.Columns[0]).HeaderFont,
                Width = 200,
                Sortable = false,
                Searchable = false,
            });
        }

        private void UpdateHex()
        {
            HexRoot = new List<HexListNode>();

            readable = new byte[bytes.Length];
            for (int i = 0; i < bytes.Length; i++ )
            {
                readable[i] = bytes[i] > 31 && bytes[i] < 127 ? bytes[i] : (byte)'.';
            }

            for (int i = 0; i < bytes.Length; i += 16)
            {
                HexRoot.Add(new HexListNode(bytes, readable, i));
            }

            listView.VirtualListDataSource = this;
        }

        internal class VariableListNode
        {
            public string Name
            {
                get
                {
                    if (Variable != null && Variable.Name != null)
                        return Variable.Name;

                    if (Parent == null)
                        return "";

                    return Parent.Children.IndexOf(this).ToString();
                }
            }
            public string Value { get { return Variable.ToString(); } }
            public string Type { get { return Variable.Type; } }
            public int EndPosition { get; set; }
            public string HexValue { get; set; }

            public int ChildCount { get { return Children.Count; } }
            public List<VariableListNode> Children { get; set; }
            public VariableListNode Parent { get; set; }
            public IEditableVariable Variable { get; set; }

            public string Method { get; set; }
        }

        internal VariableListNode CreatePropertyLayout(IEditableVariable v)
        {
            var root = AddListViewItems(v);

            Root.Add(root);

            return root;
        }

        private VariableListNode AddListViewItems(IEditableVariable v, VariableListNode parent = null, int arrayindex = 0)
        {
            var node = new VariableListNode();
            node.Variable = v;
            node.Children = new List<VariableListNode>();
            node.Parent = parent;

            var vars = v.GetEditableVariables();
            if (vars != null)
            {
                for (int i = 0; i < vars.Count; i++)
                {
                    node.Children.Add(AddListViewItems(vars[i], node, i));
                }
            }

            return node;
        }

        private void ReadBytes(int bytestart, BinaryReader reader)
        {
            reader.BaseStream.Seek(bytestart, SeekOrigin.Begin);

            try
            {
                var obj = new CVector(File);
                obj.Read(reader, (UInt32)(bytes.Length - bytestart));
                var v = CreatePropertyLayout(obj);
                v.EndPosition = (int)reader.BaseStream.Position;
                v.HexValue = bytes[bytestart].ToString("X2");
                v.Method = "CVector";
            }
            catch
            {

            }

            reader.BaseStream.Seek(bytestart, SeekOrigin.Begin);

            try
            {
                var obj = new CUInt64(File);
                obj.Read(reader, (UInt32)(bytes.Length - bytestart));
                var v = CreatePropertyLayout(obj);
                v.EndPosition = (int)reader.BaseStream.Position;
                v.HexValue = bytes[bytestart].ToString("X2");
                v.Method = "CUInt64";
            }
            catch
            {

            }

            reader.BaseStream.Seek(bytestart, SeekOrigin.Begin);

            try
            {
                var obj = new CUInt32(File);
                obj.Read(reader, (UInt32)(bytes.Length - bytestart));
                var v = CreatePropertyLayout(obj);
                v.EndPosition = (int)reader.BaseStream.Position;
                v.HexValue = bytes[bytestart].ToString("X2");
                v.Method = "CUInt32";
            }
            catch
            {

            }


            reader.BaseStream.Seek(bytestart, SeekOrigin.Begin);

            try
            {
                var obj = new CUInt16(File);
                obj.Read(reader, (UInt32)(bytes.Length - bytestart));
                var v = CreatePropertyLayout(obj);
                v.EndPosition = (int)reader.BaseStream.Position;
                v.HexValue = bytes[bytestart].ToString("X2");
                v.Method = "CUInt16";
            }
            catch
            {

            }

            reader.BaseStream.Seek(bytestart, SeekOrigin.Begin);

            try
            {
                var obj = new CUInt8(File);
                
                obj.Read(reader, (UInt32)(bytes.Length - bytestart));
                var v = CreatePropertyLayout(obj);
                v.EndPosition = (int)reader.BaseStream.Position;
                v.HexValue = bytes[bytestart].ToString("X2");
                v.Method = "CUInt8";
            }
            catch
            {

            }

            reader.BaseStream.Seek(bytestart, SeekOrigin.Begin);

            try
            {
                var obj = new CDynamicInt(File);
                obj.Read(reader, (UInt32)(bytes.Length - bytestart));
                var v = CreatePropertyLayout(obj);
                v.EndPosition = (int)reader.BaseStream.Position;
                v.HexValue = bytes[bytestart].ToString("X2");
                v.Method = "CDynamicInt";
            }
            catch
            {

            }

            reader.BaseStream.Seek(bytestart, SeekOrigin.Begin);

            try
            {
                var obj = new CFloat(File);
                obj.Read(reader, (UInt32)(bytes.Length - bytestart));
                var v = CreatePropertyLayout(obj);
                v.EndPosition = (int)reader.BaseStream.Position;
                v.HexValue = bytes[bytestart].ToString("X2");
                v.Method = "CFloat";
            }
            catch
            {

            }

            reader.BaseStream.Seek(bytestart, SeekOrigin.Begin);

            try
            {
                var obj = new CName(File);
                
                obj.Read(reader, (UInt32)(bytes.Length - bytestart));
                var v = CreatePropertyLayout(obj);
                v.EndPosition = (int)reader.BaseStream.Position;
                v.HexValue = bytes[bytestart].ToString("X2");
                v.Method = "CName";

                var valueTest = v.Value;
            }
            catch
            {

            }

            reader.BaseStream.Seek(bytestart, SeekOrigin.Begin);

            try
            {
                var obj = new CHandle(File);

                obj.Read(reader, (UInt32)(bytes.Length - bytestart));
                var v = CreatePropertyLayout(obj);
                v.EndPosition = (int)reader.BaseStream.Position;
                v.HexValue = bytes[bytestart].ToString("X2");
                v.Method = "CHandle";

                var valueTest = v.Value;
            }
            catch
            {

            }

            reader.BaseStream.Seek(bytestart, SeekOrigin.Begin);

            try
            {
                var obj = new CSoft(File);

                obj.Read(reader, (UInt32)(bytes.Length - bytestart));
                var v = CreatePropertyLayout(obj);
                v.EndPosition = (int)reader.BaseStream.Position;
                v.HexValue = bytes[bytestart].ToString("X2");
                v.Method = "CSoft";

                var valueTest = v.Value;
            }
            catch
            {

            }

            reader.BaseStream.Seek(bytestart, SeekOrigin.Begin);

            try
            {
                var obj = File.ReadVariable(reader);
                
                obj.Read(reader, (UInt32)(bytes.Length - bytestart));
                var v = CreatePropertyLayout(obj);
                v.EndPosition = (int)reader.BaseStream.Position;
                v.HexValue = bytes[bytestart].ToString("X2");
                v.Method = "ReadVariable";
            }
            catch
            {

            }

        }

        public void AddObjects(System.Collections.ICollection modelObjects)
        {

        }

        public object GetNthObject(int n)
        {
            return HexRoot[n];
        }

        public int GetObjectCount()
        {
            return HexRoot.Count;
        }

        public int GetObjectIndex(object model)
        {
            return HexRoot.IndexOf((HexListNode)model);
        }

        public void PrepareCache(int first, int last)
        {

        }

        public void RemoveObjects(System.Collections.ICollection modelObjects)
        {

        }

        public int SearchText(string value, int first, int last, OLVColumn column)
        {
            return 0;
        }

        public void SetObjects(System.Collections.IEnumerable collection)
        {

        }

        public void Sort(OLVColumn column, SortOrder order)
        {

        }

        public void UpdateObject(int index, object modelObject)
        {

        }

        private int bytestart;

        private void listView_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.Item == null || e.Column == null)
                return;

            var line = e.Item.Index;
            var byteloc = e.ColumnIndex-1;

            if (byteloc > 15 || byteloc < 0)
                return;

            bytestart = line * 16 + byteloc;

            lblPosition.Text = "ln: " + line + " col: " + byteloc + " pos: " + bytestart;

            ExaminePosition();
        }

        private void ExaminePosition()
        {
            var memstr = new MemoryStream(bytes);
            var reader = new BinaryReader(memstr);

            Root.Clear();
            treeView.Roots = null;

            var lastIndex = listView.SelectedIndex;
            listView.SelectedIndex = bytestart / 16;
            listView.EnsureVisible(listView.SelectedIndex);
            listView.Refresh();
            

            ReadBytes(bytestart, reader);

            treeView.Roots = Root;
            treeView.ExpandAll();
        }

        private void listView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                bytestart--;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                bytestart++;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                bytestart -= 16;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                bytestart += 16;
                e.SuppressKeyPress = true;
            }

            if (bytestart < 0)
                bytestart = 0;
            if (bytestart >= bytes.Length)
                bytestart = bytes.Length - 1;

            ExaminePosition();
        }

        public void InsertObjects(int index, ICollection modelObjects)
        {
            throw new NotImplementedException();
        }
    }
}
