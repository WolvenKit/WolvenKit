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
    public class CParticleEmitter : IParticleModule
    {
        [RED("modules", 2, 0)] public CArray<CPtr<IParticleModule>> Modules { get; set; }

        [RED("positionX")] public CInt32 PositionX { get; set; }

        [RED("positionY")] public CInt32 PositionY { get; set; }

        [RED("material")] public CHandle<IMaterial> Material { get; set; }

        [RED("maxParticles")] public CUInt32 MaxParticles { get; set; }

        [RED("emitterLoops")] public CInt32 EmitterLoops { get; set; }

        [RED("particleDrawer")] public CPtr<IParticleDrawer> ParticleDrawer { get; set; }

        [RED("decalSpawner")] public CPtr<CDecalSpawner> DecalSpawner { get; set; }

        [RED("collisionDecalSpawner")] public CPtr<CDecalSpawner> CollisionDecalSpawner { get; set; }

        [RED("motionDecalSpawner")] public CPtr<CDecalSpawner> MotionDecalSpawner { get; set; }

        [RED("useSubFrameEmission")] public CBool UseSubFrameEmission { get; set; }

        [RED("keepSimulationLocal")] public CBool KeepSimulationLocal { get; set; }

        [RED("envColorGroup")] public EEnvColorGroup EnvColorGroup { get; set; }

        [RED("windInfluence")] public CFloat WindInfluence { get; set; }

        [RED("useOnlyWindInfluence")] public CBool UseOnlyWindInfluence { get; set; }

        [RED("modifierSetMask")] public CUInt32 ModifierSetMask { get; set; }

        [RED("numModifiers")] public CUInt32 NumModifiers { get; set; }

        [RED("initializerSetMask")] public CUInt32 InitializerSetMask { get; set; }

        [RED("numInitializers")] public CUInt32 NumInitializers { get; set; }

        [RED("seeds", 2, 0)] public CArray<SSeedKeyValue> Seeds { get; set; }

        [RED("internalPriority")] public CUInt8 InternalPriority { get; set; }

        [RED("lods", 2, 0)] public CArray<SParticleEmitterLODLevel> Lods { get; set; }

        [REDBuffer] public SParticleEmitterModuleData moduleData { get; set; }

        public CParticleEmitter(CR2WFile cr2w) : base(cr2w)
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
            return new CParticleEmitter(cr2w);
        }

    }
}