using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Edit.CR2W.Editors;

namespace W3Edit.CR2W.Types
{
    public class CMaterialGraphParameter : CVariable
    {
        public CUInt8 unk1, unk2;
        public CName name;


        public CMaterialGraphParameter(CR2WFile cr2w)
            : base(cr2w)
        {
            unk1 = new CUInt8(cr2w) { Name = "Type", Type = "UInt8" };
            unk2 = new CUInt8(cr2w) { Name = "Offset?", Type = "UInt8" };
            name = new CName(cr2w) { Name = "Name", Type = "CName" };
        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            unk1.Read(file, size);
            unk2.Read(file, size);
            name.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            unk1.Write(file);
            unk2.Write(file);
            name.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CMaterialGraphParameter(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CMaterialGraphParameter)base.Copy(context);
            var.unk1.val = unk1.val;
            var.unk2.val = unk2.val;
            var.name.val = name.val;
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var vars = new List<IEditableVariable>();
            vars.Add(unk1);
            vars.Add(unk2);
            vars.Add(name);
            return vars;
        }

        public override string ToString()
        {
            return "";
        }
    }

    public class CMaterialGraph : CVector
    {
        public CArray pixelParameters;
        public CArray vertexParameters;

        public CMaterialGraph(CR2WFile cr2w) :
            base(cr2w)
        {
            pixelParameters = new CArray("array:0,0,CMaterialGraphParameter", "CMaterialGraphParameter", true, cr2w);
            pixelParameters.Name = "pixelParameters";
            vertexParameters = new CArray("array:0,0,CMaterialGraphParameter", "CMaterialGraphParameter", true, cr2w);
            vertexParameters.Name = "vertexParameters";
        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            base.Read(file, size);

            var count = file.ReadSByte();

            for (int i = 0; i < count; i++)
            {
                var item = new CMaterialGraphParameter(cr2w);
                item.Read(file, 0);
                pixelParameters.AddVariable(item);
            }

            var vertexCount = file.ReadSByte();

            for (int i = 0; i < vertexCount; i++)
            {
                var item = new CMaterialGraphParameter(cr2w);
                item.Read(file, 0);
                vertexParameters.AddVariable(item);
            }

            var unk1 = file.ReadInt32();

            if (unk1 != 0)
            {
                // this should be 0...

            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            file.Write((SByte)pixelParameters.array.Count);
            foreach (var item in pixelParameters)
            {
                var startpos = file.BaseStream.Position;
                item.Write(file);
            }

            file.Write((SByte)vertexParameters.array.Count);
            foreach (var item in vertexParameters)
            {
                var startpos = file.BaseStream.Position;
                item.Write(file);
            }

            file.Write((int)0);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CMaterialGraph(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CMaterialGraph)base.Copy(context);
            var.pixelParameters = (CArray)pixelParameters.Copy(context);
            var.vertexParameters = (CArray)vertexParameters.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables);
            list.Add(pixelParameters);
            list.Add(vertexParameters);
            return list;
        }
    }
}
