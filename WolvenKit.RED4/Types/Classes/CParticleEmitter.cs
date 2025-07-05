using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleEmitter : IParticleModule
	{
		[Ordinal(3)] 
		[RED("modules")] 
		public CArray<CHandle<IParticleModule>> Modules
		{
			get => GetPropertyValue<CArray<CHandle<IParticleModule>>>();
			set => SetPropertyValue<CArray<CHandle<IParticleModule>>>(value);
		}

		[Ordinal(4)] 
		[RED("positionX")] 
		public CInt32 PositionX
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("positionY")] 
		public CInt32 PositionY
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("material")] 
		public CResourceReference<IMaterial> Material
		{
			get => GetPropertyValue<CResourceReference<IMaterial>>();
			set => SetPropertyValue<CResourceReference<IMaterial>>(value);
		}

		[Ordinal(7)] 
		[RED("localMaterialInstance")] 
		public CHandle<IMaterial> LocalMaterialInstance
		{
			get => GetPropertyValue<CHandle<IMaterial>>();
			set => SetPropertyValue<CHandle<IMaterial>>(value);
		}

		[Ordinal(8)] 
		[RED("maxParticles")] 
		public CUInt16 MaxParticles
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(9)] 
		[RED("diffuseWrapFactor")] 
		public CFloat DiffuseWrapFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("backLightingFactor")] 
		public CFloat BackLightingFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("lightingMipBias")] 
		public CUInt32 LightingMipBias
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("emitterLoops")] 
		public CInt8 EmitterLoops
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		[Ordinal(13)] 
		[RED("particleDrawer")] 
		public CHandle<IParticleDrawer> ParticleDrawer
		{
			get => GetPropertyValue<CHandle<IParticleDrawer>>();
			set => SetPropertyValue<CHandle<IParticleDrawer>>(value);
		}

		[Ordinal(14)] 
		[RED("decalSpawner")] 
		public CHandle<CDecalSpawner> DecalSpawner
		{
			get => GetPropertyValue<CHandle<CDecalSpawner>>();
			set => SetPropertyValue<CHandle<CDecalSpawner>>(value);
		}

		[Ordinal(15)] 
		[RED("maskInsideCar")] 
		public CBool MaskInsideCar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("maskInsideInterior")] 
		public CBool MaskInsideInterior
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("maskAboveWater")] 
		public CBool MaskAboveWater
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("maskUnderWater")] 
		public CBool MaskUnderWater
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("useSubFrameEmission")] 
		public CBool UseSubFrameEmission
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("keepSimulationLocal")] 
		public CBool KeepSimulationLocal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("killOnCollision")] 
		public CBool KillOnCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("initialParticleCount")] 
		public CUInt8 InitialParticleCount
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(23)] 
		[RED("envColorGroup")] 
		public CEnum<EEnvColorGroup> EnvColorGroup
		{
			get => GetPropertyValue<CEnum<EEnvColorGroup>>();
			set => SetPropertyValue<CEnum<EEnvColorGroup>>(value);
		}

		[Ordinal(24)] 
		[RED("emitterGroup")] 
		public CEnum<EEmitterGroup> EmitterGroup
		{
			get => GetPropertyValue<CEnum<EEmitterGroup>>();
			set => SetPropertyValue<CEnum<EEmitterGroup>>(value);
		}

		[Ordinal(25)] 
		[RED("renderObjectType")] 
		public CEnum<ERenderObjectType> RenderObjectType
		{
			get => GetPropertyValue<CEnum<ERenderObjectType>>();
			set => SetPropertyValue<CEnum<ERenderObjectType>>(value);
		}

		[Ordinal(26)] 
		[RED("windInfluence")] 
		public CFloat WindInfluence
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("internalPriority")] 
		public CUInt8 InternalPriority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(28)] 
		[RED("lods")] 
		public CArray<SParticleEmitterLODLevel> Lods
		{
			get => GetPropertyValue<CArray<SParticleEmitterLODLevel>>();
			set => SetPropertyValue<CArray<SParticleEmitterLODLevel>>(value);
		}

		[Ordinal(29)] 
		[RED("renderResourceBlob")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlob
		{
			get => GetPropertyValue<CHandle<IRenderResourceBlob>>();
			set => SetPropertyValue<CHandle<IRenderResourceBlob>>(value);
		}

		[Ordinal(30)] 
		[RED("Enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("Relative")] 
		public CBool Relative
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("UseEnvironmentFogColor")] 
		public CBool UseEnvironmentFogColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("Color")] 
		public HDRColor Color
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(34)] 
		[RED("Size")] 
		public CFloat Size
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(35)] 
		[RED("Density")] 
		public CFloat Density
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("Falloff")] 
		public CFloat Falloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("NoiseScale")] 
		public CFloat NoiseScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("NoiseThreshold")] 
		public CFloat NoiseThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("NoiseVelocity")] 
		public Vector3 NoiseVelocity
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public CParticleEmitter()
		{
			IsEnabled = true;
			Modules = new();
			MaxParticles = 55;
			DiffuseWrapFactor = 0.650000F;
			BackLightingFactor = 0.500000F;
			RenderObjectType = Enums.ERenderObjectType.ROT_Particle;
			Lods = new();
			Color = new HDRColor { Red = 1.000000F, Green = 1.000000F, Blue = 1.000000F, Alpha = 1.000000F };
			Size = 1.000000F;
			Density = 1.000000F;
			Falloff = 1.000000F;
			NoiseScale = 1.000000F;
			NoiseVelocity = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
