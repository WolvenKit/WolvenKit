using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CStorySceneSection : CVector
    {
        public List<CVariable> sceneEventElements = new List<CVariable>();

        public CStorySceneSection(CR2WFile cr2w) :
            base(cr2w)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var count = file.ReadInt32();
            for (var i = 0; i < count; i++)
            {
                var elementsize = file.ReadUInt32();
                var typeId = file.ReadUInt16();
                var typeName = cr2w.names[typeId].Str;

                var item = CR2WTypeManager.Get().GetByName(typeName, "", cr2w, false) ?? new CVector(cr2w);

                item.Read(file, elementsize);
                item.Type = typeName;
                sceneEventElements.Add(item);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            file.Write((uint) sceneEventElements.Count);
            foreach (var item in sceneEventElements)
            {
                var startpos = file.BaseStream.Position;

                file.Write((uint) 0);
                file.Write(item.typeId);

                item.Write(file);

                var endpos = file.BaseStream.Position;
                var newsize = (uint) (endpos - startpos);

                file.Seek((int) startpos, SeekOrigin.Begin);
                file.Write(newsize);
                file.Seek((int) endpos, SeekOrigin.Begin);
            }
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CStorySceneSection(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CStorySceneSection) base.Copy(context);

            foreach (var item in sceneEventElements)
            {
                var.sceneEventElements.Add(item.Copy(context));
            }

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables);
            list.Add(new EditableList<CVariable>(sceneEventElements, cr2w) {Name = "sceneEventElements"});
            return list;
        }
    }
}