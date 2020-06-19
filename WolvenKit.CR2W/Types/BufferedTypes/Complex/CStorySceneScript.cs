using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    public partial class CStorySceneScript : CStorySceneControlPart
    {

        [REDBuffer(true)] public CCompressedBuffer<CVariant> parameters { get; set; }

        public CStorySceneScript(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            parameters = new CCompressedBuffer<CVariant>(cr2w, this, nameof(parameters), _ => new CVariant(_, this, nameof(parameters)));
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            while (true)
            {
                var nameId = file.ReadUInt16();

                if (nameId == 0)
                    break;

                // read cvariant
                var varname = cr2w.names[nameId].Str;
                CVariant cVariant = new CVariant(cr2w, parameters, varname);
                cVariant.Read(file, 0);

                parameters.Add(cVariant);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            for (var i = 0; i < parameters.Count; i++)
            {
                var variable = parameters[i];

                file.Write(variable.GetnameId());

                variable.Write(file);
            }
            file.Write((ushort)0);
        }

    }
}