using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CParticleEmitter : IParticleModule
	{
		[Ordinal(1)] [RED("modules", 2,0)] 		public CArray<CPtr<IParticleModule>> Modules { get; set;}

		[Ordinal(2)] [RED("positionX")] 		public CInt32 PositionX { get; set;}

		[Ordinal(3)] [RED("positionY")] 		public CInt32 PositionY { get; set;}

		[Ordinal(4)] [RED("material")] 		public CHandle<IMaterial> Material { get; set;}

		[Ordinal(5)] [RED("maxParticles")] 		public CUInt32 MaxParticles { get; set;}

		[Ordinal(6)] [RED("emitterLoops")] 		public CInt32 EmitterLoops { get; set;}

		[Ordinal(7)] [RED("particleDrawer")] 		public CPtr<IParticleDrawer> ParticleDrawer { get; set;}

		[Ordinal(8)] [RED("decalSpawner")] 		public CPtr<CDecalSpawner> DecalSpawner { get; set;}

		[Ordinal(9)] [RED("collisionDecalSpawner")] 		public CPtr<CDecalSpawner> CollisionDecalSpawner { get; set;}

		[Ordinal(10)] [RED("motionDecalSpawner")] 		public CPtr<CDecalSpawner> MotionDecalSpawner { get; set;}

		[Ordinal(11)] [RED("useSubFrameEmission")] 		public CBool UseSubFrameEmission { get; set;}

		[Ordinal(12)] [RED("keepSimulationLocal")] 		public CBool KeepSimulationLocal { get; set;}

		[Ordinal(13)] [RED("envColorGroup")] 		public CEnum<EEnvColorGroup> EnvColorGroup { get; set;}

		[Ordinal(14)] [RED("windInfluence")] 		public CFloat WindInfluence { get; set;}

		[Ordinal(15)] [RED("useOnlyWindInfluence")] 		public CBool UseOnlyWindInfluence { get; set;}

		[Ordinal(16)] [RED("modifierSetMask")] 		public CUInt32 ModifierSetMask { get; set;}

		[Ordinal(17)] [RED("numModifiers")] 		public CUInt32 NumModifiers { get; set;}

		[Ordinal(18)] [RED("initializerSetMask")] 		public CUInt32 InitializerSetMask { get; set;}

		[Ordinal(19)] [RED("numInitializers")] 		public CUInt32 NumInitializers { get; set;}

		[Ordinal(20)] [RED("seeds", 2,0)] 		public CArray<SSeedKeyValue> Seeds { get; set;}

		[Ordinal(21)] [RED("internalPriority")] 		public CUInt8 InternalPriority { get; set;}

		[Ordinal(22)] [RED("lods", 2,0)] 		public CArray<SParticleEmitterLODLevel> Lods { get; set;}

		public CParticleEmitter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleEmitter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}