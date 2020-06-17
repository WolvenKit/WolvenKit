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
    public class CStorySceneScript : CStorySceneControlPart
    {
        [RED("functionName")] public CName FunctionName { get; set; }

        [RED("links", 2, 0)] public CArray<CPtr<CStorySceneLinkElement>> Links { get; set; }

        [REDBuffer(true)] public List<CVariable> parameters { get; set; }

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

                var typename = cr2w.names[typeId].Str;
                var varname = cr2w.names[nameId].Str;

                var variable = CR2WTypeManager.Create(typename, varname, cr2w, this);
                variable.Read(file, lsize - 4);

                //variable.RedType = typename;
                variable.Name = varname;

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
                file.Write((uint)0); // placeholder

                variable.Write(file);
                var endpos = file.BaseStream.Position;

                var newsize = (uint)(endpos - startpos);

                file.Seek((int)startpos, SeekOrigin.Begin);
                file.Write(newsize);
                file.Seek((int)endpos, SeekOrigin.Begin);
            }
            file.Write((ushort)0);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CStorySceneScript(cr2w);
        }

    }
}