using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CStorySceneScript : CVector
    {
        public List<CVariable> parameters = new List<CVariable>();

        public CStorySceneScript(CR2WFile cr2w) :
            base(cr2w)
        {
        }

        public void SetScriptFunction(string functionName, CVariable[] lParameters)
        {
            parameters.Clear();
            parameters.AddRange(lParameters);
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            while (true)
            {
                var nameId = file.ReadUInt16();

                if (nameId == 0)
                    break;

                var typeId = file.ReadUInt16();
                var lsize = file.ReadUInt32();

                var typename = cr2w.names[typeId].str;

                var variable = CR2WTypeManager.Get().GetByName(typename, "", cr2w);
                variable.Read(file, lsize - 4);

                variable.typeId = typeId;
                variable.nameId = nameId;

                parameters.Add(variable);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            for (var i = 0; i < parameters.Count; i++)
            {
                var variable = parameters[i];

                file.Write(variable.nameId);
                file.Write(variable.typeId);

                var startpos = file.BaseStream.Position;
                file.Write((uint) 0); // placeholder

                variable.Write(file);
                var endpos = file.BaseStream.Position;

                var newsize = (uint) (endpos - startpos);

                file.Seek((int) startpos, SeekOrigin.Begin);
                file.Write(newsize);
                file.Seek((int) endpos, SeekOrigin.Begin);
            }
            file.Write((ushort) 0);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CStorySceneScript(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CStorySceneScript) base.Copy(context);

            foreach (var item in parameters)
            {
                var.parameters.Add(item.Copy(context));
            }

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables);
            list.Add(new EditableList<CVariable>(parameters, cr2w) {Name = "functionParameters"});
            return list;
        }
    }
    
    public class CQuestScriptBlock : CStorySceneScript
    {
        public CQuestScriptBlock(CR2WFile cr2w) :
            base(cr2w)
        {
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CQuestScriptBlock(cr2w);
        }
    }

}