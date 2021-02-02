using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendRenderParticleBlobEmitterInfo : CVariable
	{
		[Ordinal(0)]  [RED("emitterHash")] public CUInt64 EmitterHash { get; set; }
		[Ordinal(1)]  [RED("diffuseWrapFactor")] public CFloat DiffuseWrapFactor { get; set; }
		[Ordinal(2)]  [RED("backLightingFactor")] public CFloat BackLightingFactor { get; set; }
		[Ordinal(3)]  [RED("lightingMipBias")] public CUInt32 LightingMipBias { get; set; }
		[Ordinal(4)]  [RED("maxParticles")] public CUInt32 MaxParticles { get; set; }
		[Ordinal(5)]  [RED("emitterLoops")] public CInt8 EmitterLoops { get; set; }
		[Ordinal(6)]  [RED("internalPriority")] public CUInt8 InternalPriority { get; set; }
		[Ordinal(7)]  [RED("maskInsideCar")] public CBool MaskInsideCar { get; set; }
		[Ordinal(8)]  [RED("maskInsideInterior")] public CBool MaskInsideInterior { get; set; }
		[Ordinal(9)]  [RED("maskAboveWater")] public CBool MaskAboveWater { get; set; }
		[Ordinal(10)]  [RED("maskUnderWater")] public CBool MaskUnderWater { get; set; }
		[Ordinal(11)]  [RED("keepSimulationLocal")] public CBool KeepSimulationLocal { get; set; }
		[Ordinal(12)]  [RED("killOnCollision")] public CBool KillOnCollision { get; set; }
		[Ordinal(13)]  [RED("initialParticleCount")] public CUInt8 InitialParticleCount { get; set; }
		[Ordinal(14)]  [RED("useSubFrameEmission")] public CBool UseSubFrameEmission { get; set; }
		[Ordinal(15)]  [RED("windInfluence")] public CFloat WindInfluence { get; set; }
		[Ordinal(16)]  [RED("particleType")] public CUInt32 ParticleType { get; set; }
		[Ordinal(17)]  [RED("vertexDrawerType")] public CUInt32 VertexDrawerType { get; set; }
		[Ordinal(18)]  [RED("simulationType")] public CUInt32 SimulationType { get; set; }
		[Ordinal(19)]  [RED("envColorGroup")] public CUInt32 EnvColorGroup { get; set; }
		[Ordinal(20)]  [RED("emitterGroup")] public CUInt32 EmitterGroup { get; set; }
		[Ordinal(21)]  [RED("renderObjectType")] public CEnum<ERenderObjectType> RenderObjectType { get; set; }
		[Ordinal(22)]  [RED("numModifiers")] public CUInt32 NumModifiers { get; set; }
		[Ordinal(23)]  [RED("numInitializers")] public CUInt32 NumInitializers { get; set; }
		[Ordinal(24)]  [RED("modifierSetMask")] public CUInt64 ModifierSetMask { get; set; }
		[Ordinal(25)]  [RED("initializerSetMask")] public CUInt64 InitializerSetMask { get; set; }
		[Ordinal(26)]  [RED("simulationHash")] public CUInt64 SimulationHash { get; set; }
		[Ordinal(27)]  [RED("eventSetMask")] public CUInt16 EventSetMask { get; set; }
		[Ordinal(28)]  [RED("seeds")] public CArray<CUInt32> Seeds { get; set; }
		[Ordinal(29)]  [RED("lods")] public CArray<rendEmitterLOD> Lods { get; set; }
		[Ordinal(30)]  [RED("volumetricParticleEnabled")] public CBool VolumetricParticleEnabled { get; set; }
		[Ordinal(31)]  [RED("volumetricParticleRelative")] public CBool VolumetricParticleRelative { get; set; }
		[Ordinal(32)]  [RED("volumetricParticleUseFogColor")] public CBool VolumetricParticleUseFogColor { get; set; }
		[Ordinal(33)]  [RED("volumetricParticleColor")] public HDRColor VolumetricParticleColor { get; set; }
		[Ordinal(34)]  [RED("volumetricParticleSize")] public CFloat VolumetricParticleSize { get; set; }
		[Ordinal(35)]  [RED("volumetricParticleDensity")] public CFloat VolumetricParticleDensity { get; set; }
		[Ordinal(36)]  [RED("volumetricParticleFalloff")] public CFloat VolumetricParticleFalloff { get; set; }
		[Ordinal(37)]  [RED("volumetricParticleNoiseScale")] public CFloat VolumetricParticleNoiseScale { get; set; }
		[Ordinal(38)]  [RED("volumetricParticleNoiseThreshold")] public CFloat VolumetricParticleNoiseThreshold { get; set; }
		[Ordinal(39)]  [RED("volumetricParticleNoiseVelocity")] public Vector3 VolumetricParticleNoiseVelocity { get; set; }

		public rendRenderParticleBlobEmitterInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
