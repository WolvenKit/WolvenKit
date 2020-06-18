using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CExtAnimEventsFile : CResource
    {
        [RED("requiredSfxTag")] public CName RequiredSfxTag { get; set; }

        [REDBuffer] public CUInt32 unk1 { get; set; }

        public CExtAnimEventsFile(CR2WFile cr2w) :
            base(cr2w)
        {

            
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CExtAnimEventsFile(cr2w);
        }

    }
}