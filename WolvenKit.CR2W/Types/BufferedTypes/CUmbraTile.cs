using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CUmbraTile : CResource
    {
        [RED("dataStatus")] public EUmbraTileDataStatus DataStatus { get; set; }

        [RED("data")] public DeferredDataBuffer Data { get; set; }

        //public CBufferUInt32<CHandle<>> tiles;
            
        public CUmbraTile(CR2WFile cr2w) :
            base(cr2w)
        {
            //tiles = new CBufferUInt32<CHandle<>>(cr2w, _ => new CHandle<>(_));
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            //tiles.Read(file, 0);
           
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            //tiles.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CUmbraTile(cr2w);
        }

       
    }
}