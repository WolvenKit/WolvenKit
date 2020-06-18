using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CMaterialInstance : IMaterial
    {
        [RED("baseMaterial")] public CHandle<IMaterial> BaseMaterial { get; set; }

        [RED("enableMask")] public CBool EnableMask { get; set; }

        [REDBuffer] public CArray<CVariantSizeNameType> InstanceParameters { get; set; }

        public CMaterialInstance(CR2WFile cr2w) :
            base(cr2w)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            //var count = file.ReadInt32();
            //for (var i = 0; i < count; i++)
            //{
            //    var elementsize = file.ReadUInt32();
            //    var nameId = file.ReadUInt16();
            //    var typeId = file.ReadUInt16();
            //    var typeName = cr2w.names[typeId].Str;
            //    var varname = cr2w.names[nameId].Str;

            //    var item = CR2WTypeManager.Get().GetByName(typeName, varname, cr2w, false);
            //    if (item == null)
            //        item = new CVector(cr2w);


            //    item.Read(file, elementsize);
            //    item.Type = typeName;
            //    item.Name = varname;
            //    instanceParameters.Add(item);
            //}
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            //file.Write((uint) instanceParameters.Count);
            //foreach (var item in instanceParameters)
            //{
            //    var startpos = file.BaseStream.Position;

            //    file.Write((uint) 0);
            //    file.Write(item.nameId);
            //    file.Write(item.typeId);

            //    item.Write(file);

            //    var endpos = file.BaseStream.Position;
            //    var newsize = (uint) (endpos - startpos);

            //    file.Seek((int) startpos, SeekOrigin.Begin);
            //    file.Write(newsize);
            //    file.Seek((int) endpos, SeekOrigin.Begin);
            //}
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CMaterialInstance(cr2w);
        }

        
    }
}