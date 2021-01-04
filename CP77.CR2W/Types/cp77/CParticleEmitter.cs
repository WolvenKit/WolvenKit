using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleEmitter : IParticleModule
	{
		[Ordinal(0)]  [RED("Color")] public HDRColor Color { get; set; }
		[Ordinal(1)]  [RED("Density")] public CFloat Density { get; set; }
		[Ordinal(2)]  [RED("Enabled")] public CBool Enabled { get; set; }
		[Ordinal(3)]  [RED("Falloff")] public CFloat Falloff { get; set; }
		[Ordinal(4)]  [RED("NoiseScale")] public CFloat NoiseScale { get; set; }
		[Ordinal(5)]  [RED("NoiseThreshold")] public CFloat NoiseThreshold { get; set; }
		[Ordinal(6)]  [RED("NoiseVelocity")] public Vector3 NoiseVelocity { get; set; }
		[Ordinal(7)]  [RED("Relative")] public CBool Relative { get; set; }
		[Ordinal(8)]  [RED("Size")] public CFloat Size { get; set; }
		[Ordinal(9)]  [RED("UseEnvironmentFogColor")] public CBool UseEnvironmentFogColor { get; set; }
		[Ordinal(10)]  [RED("backLightingFactor")] public CFloat BackLightingFactor { get; set; }
		[Ordinal(11)]  [RED("decalSpawner")] public CHandle<CDecalSpawner> DecalSpawner { get; set; }
		[Ordinal(12)]  [RED("diffuseWrapFactor")] public CFloat DiffuseWrapFactor { get; set; }
		[Ordinal(13)]  [RED("emitterGroup")] public CEnum<EEmitterGroup> EmitterGroup { get; set; }
		[Ordinal(14)]  [RED("emitterLoops")] public CInt8 EmitterLoops { get; set; }
		[Ordinal(15)]  [RED("envColorGroup")] public CEnum<EEnvColorGroup> EnvColorGroup { get; set; }
		[Ordinal(16)]  [RED("initialParticleCount")] public CUInt8 InitialParticleCount { get; set; }
		[Ordinal(17)]  [RED("internalPriority")] public CUInt8 InternalPriority { get; set; }
		[Ordinal(18)]  [RED("keepSimulationLocal")] public CBool KeepSimulationLocal { get; set; }
		[Ordinal(19)]  [RED("killOnCollision")] public CBool KillOnCollision { get; set; }
		[Ordinal(20)]  [RED("lightingMipBias")] public CUInt32 LightingMipBias { get; set; }
		[Ordinal(21)]  [RED("localMaterialInstance")] public CHandle<IMaterial> LocalMaterialInstance { get; set; }
		[Ordinal(22)]  [RED("lods")] public CArray<SParticleEmitterLODLevel> Lods { get; set; }
		[Ordinal(23)]  [RED("maskAboveWater")] public CBool MaskAboveWater { get; set; }
		[Ordinal(24)]  [RED("maskInsideCar")] public CBool MaskInsideCar { get; set; }
		[Ordinal(25)]  [RED("maskInsideInterior")] public CBool MaskInsideInterior { get; set; }
		[Ordinal(26)]  [RED("maskUnderWater")] public CBool MaskUnderWater { get; set; }
		[Ordinal(27)]  [RED("material")] public rRef<IMaterial> Material { get; set; }
		[Ordinal(28)]  [RED("maxParticles")] public CUInt16 MaxParticles { get; set; }
		[Ordinal(29)]  [RED("modules")] public CArray<CHandle<IParticleModule>> Modules { get; set; }
		[Ordinal(30)]  [RED("particleDrawer")] public CHandle<IParticleDrawer> ParticleDrawer { get; set; }
		[Ordinal(31)]  [RED("positionX")] public CInt32 PositionX { get; set; }
		[Ordinal(32)]  [RED("positionY")] public CInt32 PositionY { get; set; }
		[Ordinal(33)]  [RED("renderObjectType")] public CEnum<ERenderObjectType> RenderObjectType { get; set; }
		[Ordinal(34)]  [RED("renderResourceBlob")] public CHandle<IRenderResourceBlob> RenderResourceBlob { get; set; }
		[Ordinal(35)]  [RED("useSubFrameEmission")] public CBool UseSubFrameEmission { get; set; }
		[Ordinal(36)]  [RED("windInfluence")] public CFloat WindInfluence { get; set; }

		public CParticleEmitter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
