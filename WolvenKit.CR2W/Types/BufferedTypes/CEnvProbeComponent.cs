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
    public class CEnvProbeComponent : CComponent
    {
        [RED("contribution")] public CFloat Contribution { get; set; }

        [RED("nestingLevel")] public CUInt32 NestingLevel { get; set; }

        [RED("effectIntensity")] public CFloat EffectIntensity { get; set; }

        [RED("areaMarginFactor")] public Vector AreaMarginFactor { get; set; }

        [RED("areaDisplace")] public Vector AreaDisplace { get; set; }

        [RED("isParallaxCorrected")] public CBool IsParallaxCorrected { get; set; }

        [RED("parallaxTransform")] public EngineTransform ParallaxTransform { get; set; }

        [RED("genParams")] public SEnvProbeGenParams GenParams { get; set; }

        [RED("textureCacheHashes")] public /*Static*/CArray<CUInt32> TextureCacheHashes { get; set; }

        [REDBuffer] public CBufferUInt32<Vector> unk1 { get; set; }

        public CEnvProbeComponent(CR2WFile cr2w) :
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
            return new CEnvProbeComponent(cr2w);
        }
    }
}