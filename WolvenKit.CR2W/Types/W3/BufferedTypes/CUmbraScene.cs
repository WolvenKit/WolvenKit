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
    public class CUmbraScene : CResource
    {
        [RED("distanceMultiplier")] public CFloat DistanceMultiplier { get; set; }

        [RED("localUmbraOccThresholdMul")] public CHandle<CResourceSimplexTree> LocalUmbraOccThresholdMul { get; set; }

        public CUInt32 unk1 { get; set; }
        public CFloat unk2 { get; set; }

        public CBufferUInt32<SUmbraSceneData> tiles;
            
        public CUmbraScene(CR2WFile cr2w) :
            base(cr2w)
        {
            unk1 = new CUInt32(cr2w) { Name = nameof(unk1) };
            unk2 = new CFloat(cr2w) { Name = nameof(unk2) };
            tiles = new CBufferUInt32<SUmbraSceneData>(cr2w, _ => new SUmbraSceneData(_))
            {
                Name = nameof(tiles)
            };
            
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            unk1.Read(file, 4);
            unk2.Read(file, 4);
            tiles.Read(file, 0);
           
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            unk1.Write(file);
            unk2.Write(file);
            tiles.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CUmbraScene(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CUmbraScene) base.Copy(context);

            var.unk1 = (CUInt32)unk1.Copy(context);
            var.unk2 = (CFloat)unk2.Copy(context);
            var.tiles = (CBufferUInt32<SUmbraSceneData>)tiles.Copy(context);

            return var;
        }
    }
}