using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderParticleBlobEmitterInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("emitterHash")] 
		public CUInt64 EmitterHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("diffuseWrapFactor")] 
		public CFloat DiffuseWrapFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("backLightingFactor")] 
		public CFloat BackLightingFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("lightingMipBias")] 
		public CUInt32 LightingMipBias
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("maskInsideCar")] 
		public CBool MaskInsideCar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("maskInsideInterior")] 
		public CBool MaskInsideInterior
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("maskAboveWater")] 
		public CBool MaskAboveWater
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("maskUnderWater")] 
		public CBool MaskUnderWater
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("maxParticles")] 
		public CUInt32 MaxParticles
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("emitterLoops")] 
		public CInt8 EmitterLoops
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		[Ordinal(10)] 
		[RED("internalPriority")] 
		public CUInt8 InternalPriority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(11)] 
		[RED("keepSimulationLocal")] 
		public CBool KeepSimulationLocal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("killOnCollision")] 
		public CBool KillOnCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("initialParticleCount")] 
		public CUInt8 InitialParticleCount
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(14)] 
		[RED("useSubFrameEmission")] 
		public CBool UseSubFrameEmission
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("windInfluence")] 
		public CFloat WindInfluence
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("particleType")] 
		public CUInt32 ParticleType
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(17)] 
		[RED("vertexDrawerType")] 
		public CUInt32 VertexDrawerType
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(18)] 
		[RED("simulationType")] 
		public CUInt32 SimulationType
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(19)] 
		[RED("envColorGroup")] 
		public CUInt32 EnvColorGroup
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(20)] 
		[RED("emitterGroup")] 
		public CUInt32 EmitterGroup
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(21)] 
		[RED("renderObjectType")] 
		public CEnum<ERenderObjectType> RenderObjectType
		{
			get => GetPropertyValue<CEnum<ERenderObjectType>>();
			set => SetPropertyValue<CEnum<ERenderObjectType>>(value);
		}

		[Ordinal(22)] 
		[RED("numModifiers")] 
		public CUInt32 NumModifiers
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(23)] 
		[RED("modifierSetMask")] 
		public CUInt64 ModifierSetMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(24)] 
		[RED("numInitializers")] 
		public CUInt32 NumInitializers
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(25)] 
		[RED("initializerSetMask")] 
		public CUInt64 InitializerSetMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(26)] 
		[RED("simulationHash")] 
		public CUInt64 SimulationHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(27)] 
		[RED("eventSetMask")] 
		public CUInt16 EventSetMask
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(28)] 
		[RED("seeds")] 
		public CArray<CUInt32> Seeds
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(29)] 
		[RED("lods")] 
		public CArray<rendEmitterLOD> Lods
		{
			get => GetPropertyValue<CArray<rendEmitterLOD>>();
			set => SetPropertyValue<CArray<rendEmitterLOD>>(value);
		}

		[Ordinal(30)] 
		[RED("volumetricParticleEnabled")] 
		public CBool VolumetricParticleEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("volumetricParticleRelative")] 
		public CBool VolumetricParticleRelative
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("volumetricParticleUseFogColor")] 
		public CBool VolumetricParticleUseFogColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("volumetricParticleColor")] 
		public HDRColor VolumetricParticleColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(34)] 
		[RED("volumetricParticleSize")] 
		public CFloat VolumetricParticleSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(35)] 
		[RED("volumetricParticleDensity")] 
		public CFloat VolumetricParticleDensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("volumetricParticleFalloff")] 
		public CFloat VolumetricParticleFalloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("volumetricParticleNoiseScale")] 
		public CFloat VolumetricParticleNoiseScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("volumetricParticleNoiseThreshold")] 
		public CFloat VolumetricParticleNoiseThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("volumetricParticleNoiseVelocity")] 
		public Vector3 VolumetricParticleNoiseVelocity
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public rendRenderParticleBlobEmitterInfo()
		{
			RenderObjectType = Enums.ERenderObjectType.ROT_Particle;
			Seeds = new();
			Lods = new();
			VolumetricParticleColor = new HDRColor { Red = 1.000000F, Green = 1.000000F, Blue = 1.000000F, Alpha = 1.000000F };
			VolumetricParticleNoiseVelocity = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
