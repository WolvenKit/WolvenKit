using System.Collections.Generic;
using System.IO;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CCubeTexture : CVector
    {
        public CByteArray left;
        public CByteArray right;
        public CByteArray front;
        public CByteArray back;
        public CByteArray top;
        public CByteArray bottom;


        public CCubeTexture(CR2WFile cr2w) : base(cr2w)
        {
            left = new CByteArray(cr2w)
            {
                Name = "left"
            };
            right = new CByteArray(cr2w)
            {
                Name = "right"
            };
            front = new CByteArray(cr2w)
            {
                Name = "front"
            };
            back = new CByteArray(cr2w)
            {
                Name = "back"
            };
            top = new CByteArray(cr2w)
            {
                Name = "top"
            };
            bottom = new CByteArray(cr2w)
            {
                Name = "bottom"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            
            var bytes_left = file.BaseStream.Length - file.BaseStream.Position;
            left.Bytes = file.ReadBytes((int)(bytes_left/6+1));
            right.Bytes = file.ReadBytes((int)(bytes_left/6+1));
            front.Bytes = file.ReadBytes((int)(bytes_left/6+1));
            back.Bytes = file.ReadBytes((int)(bytes_left/6+1));
            top.Bytes = file.ReadBytes((int)(bytes_left/6+1));
            bottom.Bytes = file.ReadBytes((int)(bytes_left/6+1));
        }

        public override void Write(BinaryWriter file)
        {
            left.Write(file);
            right.Write(file);
            front.Write(file);
            back.Write(file);
            top.Write(file);
            bottom.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CCubeTexture(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CCubeTexture)base.Copy(context);
            var.left = (CByteArray) left.Copy(context);
            var.right = (CByteArray) right.Copy(context);
            var.front = (CByteArray) front.Copy(context);
            var.back = (CByteArray) back.Copy(context);
            var.top = (CByteArray) top.Copy(context);
            var.bottom = (CByteArray) bottom.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                left,
                right,
                front,
                back,
                top,
                bottom
            };
        }
    }
}