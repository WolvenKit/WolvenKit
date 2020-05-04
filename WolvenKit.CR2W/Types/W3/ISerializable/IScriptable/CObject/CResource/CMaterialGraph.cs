using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CMaterialGraphParameter : CVariable
    {
        public CName name;
        public CUInt8 unk1, unk2;

        public CMaterialGraphParameter(CR2WFile cr2w)
            : base(cr2w)
        {
            unk1 = new CUInt8(cr2w) {Name = "Type", Type = "UInt8"};
            unk2 = new CUInt8(cr2w) {Name = "Offset?", Type = "UInt8"};
            name = new CName(cr2w) {Name = "Name", Type = "CName"};
        }

        public override void Read(BinaryReader file, uint size)
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
            var var = (CMaterialGraphParameter) base.Copy(context);
            var.unk1 = unk1;
            var.unk2 = unk2;
            var.name = name;
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

    [DataContract(Namespace = "")]
    public class CMaterialGraph : CVector
    {
        public CBufferVLQ<CMaterialGraphParameter> pixelParameters;
        public CBufferVLQ<CMaterialGraphParameter> vertexParameters;

        public CMaterialGraph(CR2WFile cr2w) :
            base(cr2w)
        {
            pixelParameters = new CBufferVLQ<CMaterialGraphParameter>(cr2w, _ => new CMaterialGraphParameter(_))
            {
                Name = "pixelParameters"
            };
            vertexParameters = new CBufferVLQ<CMaterialGraphParameter>(cr2w, _ => new CMaterialGraphParameter(_))
            {
                Name = "vertexParameters"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);


            pixelParameters.Read(file, 0);
            vertexParameters.Read(file, 0);
            //var count = file.ReadSByte();

            //for (var i = 0; i < count; i++)
            //{
            //    var item = new CMaterialGraphParameter(cr2w);
            //    item.Read(file, 0);
            //    pixelParameters.AddVariable(item);
            //}

            //var vertexCount = file.ReadSByte();

            //for (var i = 0; i < vertexCount; i++)
            //{
            //    var item = new CMaterialGraphParameter(cr2w);
            //    item.Read(file, 0);
            //    vertexParameters.AddVariable(item);
            //}

            var unk1 = file.ReadInt32();

            if (unk1 != 0)
            {
                // this should be 0...
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            pixelParameters.Write(file);
            vertexParameters.Write(file);

            //file.Write((sbyte) pixelParameters.array.Count);
            //foreach (var item in pixelParameters)
            //{
            //    var startpos = file.BaseStream.Position;
            //    item.Write(file);
            //}

            //file.Write((sbyte) vertexParameters.array.Count);
            //foreach (var item in vertexParameters)
            //{
            //    var startpos = file.BaseStream.Position;
            //    item.Write(file);
            //}

            file.Write(0);
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
            var var = (CMaterialGraph) base.Copy(context);
            var.pixelParameters = (CBufferVLQ<CMaterialGraphParameter>) pixelParameters.Copy(context);
            var.vertexParameters = (CBufferVLQ<CMaterialGraphParameter>) vertexParameters.Copy(context);

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