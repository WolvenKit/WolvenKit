using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WolvenKit.CR2W.Types
{
    public class CUInt64 : CVariable
    {
        

        public CUInt64(CR2WFile cr2w)
: base(cr2w)
        {
        }

        private ulong _val;
        public ulong val { get => _val; set => _val = value; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadUInt64();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is ulong)
            {
                this.val = (ulong)val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CUInt64(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CUInt64)base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    public class CUInt32 : CVariable
    {
        public CUInt32(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public uint val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadUInt32();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is uint)
            {
                this.val = (uint) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CUInt32(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CUInt32) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    public class CUInt16 : CVariable
    {
       

        public CUInt16(CR2WFile cr2w)
: base(cr2w)
        {
        }

        private ushort _val;
        public ushort val { get => _val; set => _val = value; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadUInt16();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is ushort)
            {
                this.val = (ushort)val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CUInt16(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CUInt16)base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    public class CUInt8 : CVariable
    {
        public CUInt8(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public byte val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadByte();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is byte)
            {
                this.val = (byte) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CUInt8(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CUInt8) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }


    public class CInt64 : CVariable
    {
        public CInt64(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public long val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadInt64();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is long)
            {
                this.val = (long) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CInt64(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CInt64) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    public class CInt32 : CVariable
    {
        public CInt32(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public int val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadInt32();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is int)
            {
                this.val = (int) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CInt32(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CInt32) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    public class CInt16 : CVariable
    {
        public CInt16(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public short val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadInt16();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is short)
            {
                this.val = (short) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CInt16(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CInt16) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    public class CInt8 : CVariable
    {
        public CInt8(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public sbyte val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadSByte();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is sbyte)
            {
                this.val = (sbyte) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CInt8(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CInt8) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    public class CDynamicInt : CVariable
    {
        public CDynamicInt(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public int val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            var result = 0;
            var shift = 0;
            byte b = 0;
            var i = 1;

            do
            {
                b = file.ReadByte();
                if (b == 128)
                {
                    result = 0;
                    break;
                }

                byte s = 6;
                byte mask = 255;
                if (b > 127)
                {
                    mask = 127;
                    s = 7;
                }
                else if (b > 63)
                {
                    if (i == 1)
                    {
                        mask = 63;
                    }
                }
                result = result | ((b & mask) << shift);
                shift = shift + s;
                i = i + 1;
            } while (!(b < 64 || (i >= 3 && b < 128)));

            val = result;
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is sbyte)
            {
                this.val = (sbyte) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CInt8(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CDynamicInt) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }

        internal byte ToByte()
        {
            byte result;
            byte.TryParse(val.ToString(), out result);
            return result;
        }
    }

    public class CBool : CVariable
    {
        public CBool(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public bool val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadByte() != 0;
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val ? (byte) 1 : (byte) 0);
        }

        public override CVariable SetValue(object val)
        {
            if (val is bool)
            {
                this.val = (bool) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBool(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CBool) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new CheckBox();
            editor.DataBindings.Add("Checked", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val ? "True" : "False";
        }
    }
}