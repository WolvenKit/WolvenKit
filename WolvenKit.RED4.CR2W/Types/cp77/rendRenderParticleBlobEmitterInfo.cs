using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderParticleBlobEmitterInfo : CVariable
	{
		private CUInt64 _emitterHash;
		private CFloat _diffuseWrapFactor;
		private CFloat _backLightingFactor;
		private CUInt32 _lightingMipBias;
		private CBool _maskInsideCar;
		private CBool _maskInsideInterior;
		private CBool _maskAboveWater;
		private CBool _maskUnderWater;
		private CUInt32 _maxParticles;
		private CInt8 _emitterLoops;
		private CUInt8 _internalPriority;
		private CBool _keepSimulationLocal;
		private CBool _killOnCollision;
		private CUInt8 _initialParticleCount;
		private CBool _useSubFrameEmission;
		private CFloat _windInfluence;
		private CUInt32 _particleType;
		private CUInt32 _vertexDrawerType;
		private CUInt32 _simulationType;
		private CUInt32 _envColorGroup;
		private CUInt32 _emitterGroup;
		private CEnum<ERenderObjectType> _renderObjectType;
		private CUInt32 _numModifiers;
		private CUInt64 _modifierSetMask;
		private CUInt32 _numInitializers;
		private CUInt64 _initializerSetMask;
		private CUInt64 _simulationHash;
		private CUInt16 _eventSetMask;
		private CArray<CUInt32> _seeds;
		private CArray<rendEmitterLOD> _lods;
		private CBool _volumetricParticleEnabled;
		private CBool _volumetricParticleRelative;
		private CBool _volumetricParticleUseFogColor;
		private HDRColor _volumetricParticleColor;
		private CFloat _volumetricParticleSize;
		private CFloat _volumetricParticleDensity;
		private CFloat _volumetricParticleFalloff;
		private CFloat _volumetricParticleNoiseScale;
		private CFloat _volumetricParticleNoiseThreshold;
		private Vector3 _volumetricParticleNoiseVelocity;

		[Ordinal(0)] 
		[RED("emitterHash")] 
		public CUInt64 EmitterHash
		{
			get => GetProperty(ref _emitterHash);
			set => SetProperty(ref _emitterHash, value);
		}

		[Ordinal(1)] 
		[RED("diffuseWrapFactor")] 
		public CFloat DiffuseWrapFactor
		{
			get => GetProperty(ref _diffuseWrapFactor);
			set => SetProperty(ref _diffuseWrapFactor, value);
		}

		[Ordinal(2)] 
		[RED("backLightingFactor")] 
		public CFloat BackLightingFactor
		{
			get => GetProperty(ref _backLightingFactor);
			set => SetProperty(ref _backLightingFactor, value);
		}

		[Ordinal(3)] 
		[RED("lightingMipBias")] 
		public CUInt32 LightingMipBias
		{
			get => GetProperty(ref _lightingMipBias);
			set => SetProperty(ref _lightingMipBias, value);
		}

		[Ordinal(4)] 
		[RED("maskInsideCar")] 
		public CBool MaskInsideCar
		{
			get => GetProperty(ref _maskInsideCar);
			set => SetProperty(ref _maskInsideCar, value);
		}

		[Ordinal(5)] 
		[RED("maskInsideInterior")] 
		public CBool MaskInsideInterior
		{
			get => GetProperty(ref _maskInsideInterior);
			set => SetProperty(ref _maskInsideInterior, value);
		}

		[Ordinal(6)] 
		[RED("maskAboveWater")] 
		public CBool MaskAboveWater
		{
			get => GetProperty(ref _maskAboveWater);
			set => SetProperty(ref _maskAboveWater, value);
		}

		[Ordinal(7)] 
		[RED("maskUnderWater")] 
		public CBool MaskUnderWater
		{
			get => GetProperty(ref _maskUnderWater);
			set => SetProperty(ref _maskUnderWater, value);
		}

		[Ordinal(8)] 
		[RED("maxParticles")] 
		public CUInt32 MaxParticles
		{
			get => GetProperty(ref _maxParticles);
			set => SetProperty(ref _maxParticles, value);
		}

		[Ordinal(9)] 
		[RED("emitterLoops")] 
		public CInt8 EmitterLoops
		{
			get => GetProperty(ref _emitterLoops);
			set => SetProperty(ref _emitterLoops, value);
		}

		[Ordinal(10)] 
		[RED("internalPriority")] 
		public CUInt8 InternalPriority
		{
			get => GetProperty(ref _internalPriority);
			set => SetProperty(ref _internalPriority, value);
		}

		[Ordinal(11)] 
		[RED("keepSimulationLocal")] 
		public CBool KeepSimulationLocal
		{
			get => GetProperty(ref _keepSimulationLocal);
			set => SetProperty(ref _keepSimulationLocal, value);
		}

		[Ordinal(12)] 
		[RED("killOnCollision")] 
		public CBool KillOnCollision
		{
			get => GetProperty(ref _killOnCollision);
			set => SetProperty(ref _killOnCollision, value);
		}

		[Ordinal(13)] 
		[RED("initialParticleCount")] 
		public CUInt8 InitialParticleCount
		{
			get => GetProperty(ref _initialParticleCount);
			set => SetProperty(ref _initialParticleCount, value);
		}

		[Ordinal(14)] 
		[RED("useSubFrameEmission")] 
		public CBool UseSubFrameEmission
		{
			get => GetProperty(ref _useSubFrameEmission);
			set => SetProperty(ref _useSubFrameEmission, value);
		}

		[Ordinal(15)] 
		[RED("windInfluence")] 
		public CFloat WindInfluence
		{
			get => GetProperty(ref _windInfluence);
			set => SetProperty(ref _windInfluence, value);
		}

		[Ordinal(16)] 
		[RED("particleType")] 
		public CUInt32 ParticleType
		{
			get => GetProperty(ref _particleType);
			set => SetProperty(ref _particleType, value);
		}

		[Ordinal(17)] 
		[RED("vertexDrawerType")] 
		public CUInt32 VertexDrawerType
		{
			get => GetProperty(ref _vertexDrawerType);
			set => SetProperty(ref _vertexDrawerType, value);
		}

		[Ordinal(18)] 
		[RED("simulationType")] 
		public CUInt32 SimulationType
		{
			get => GetProperty(ref _simulationType);
			set => SetProperty(ref _simulationType, value);
		}

		[Ordinal(19)] 
		[RED("envColorGroup")] 
		public CUInt32 EnvColorGroup
		{
			get => GetProperty(ref _envColorGroup);
			set => SetProperty(ref _envColorGroup, value);
		}

		[Ordinal(20)] 
		[RED("emitterGroup")] 
		public CUInt32 EmitterGroup
		{
			get => GetProperty(ref _emitterGroup);
			set => SetProperty(ref _emitterGroup, value);
		}

		[Ordinal(21)] 
		[RED("renderObjectType")] 
		public CEnum<ERenderObjectType> RenderObjectType
		{
			get => GetProperty(ref _renderObjectType);
			set => SetProperty(ref _renderObjectType, value);
		}

		[Ordinal(22)] 
		[RED("numModifiers")] 
		public CUInt32 NumModifiers
		{
			get => GetProperty(ref _numModifiers);
			set => SetProperty(ref _numModifiers, value);
		}

		[Ordinal(23)] 
		[RED("modifierSetMask")] 
		public CUInt64 ModifierSetMask
		{
			get => GetProperty(ref _modifierSetMask);
			set => SetProperty(ref _modifierSetMask, value);
		}

		[Ordinal(24)] 
		[RED("numInitializers")] 
		public CUInt32 NumInitializers
		{
			get => GetProperty(ref _numInitializers);
			set => SetProperty(ref _numInitializers, value);
		}

		[Ordinal(25)] 
		[RED("initializerSetMask")] 
		public CUInt64 InitializerSetMask
		{
			get => GetProperty(ref _initializerSetMask);
			set => SetProperty(ref _initializerSetMask, value);
		}

		[Ordinal(26)] 
		[RED("simulationHash")] 
		public CUInt64 SimulationHash
		{
			get => GetProperty(ref _simulationHash);
			set => SetProperty(ref _simulationHash, value);
		}

		[Ordinal(27)] 
		[RED("eventSetMask")] 
		public CUInt16 EventSetMask
		{
			get => GetProperty(ref _eventSetMask);
			set => SetProperty(ref _eventSetMask, value);
		}

		[Ordinal(28)] 
		[RED("seeds")] 
		public CArray<CUInt32> Seeds
		{
			get => GetProperty(ref _seeds);
			set => SetProperty(ref _seeds, value);
		}

		[Ordinal(29)] 
		[RED("lods")] 
		public CArray<rendEmitterLOD> Lods
		{
			get => GetProperty(ref _lods);
			set => SetProperty(ref _lods, value);
		}

		[Ordinal(30)] 
		[RED("volumetricParticleEnabled")] 
		public CBool VolumetricParticleEnabled
		{
			get => GetProperty(ref _volumetricParticleEnabled);
			set => SetProperty(ref _volumetricParticleEnabled, value);
		}

		[Ordinal(31)] 
		[RED("volumetricParticleRelative")] 
		public CBool VolumetricParticleRelative
		{
			get => GetProperty(ref _volumetricParticleRelative);
			set => SetProperty(ref _volumetricParticleRelative, value);
		}

		[Ordinal(32)] 
		[RED("volumetricParticleUseFogColor")] 
		public CBool VolumetricParticleUseFogColor
		{
			get => GetProperty(ref _volumetricParticleUseFogColor);
			set => SetProperty(ref _volumetricParticleUseFogColor, value);
		}

		[Ordinal(33)] 
		[RED("volumetricParticleColor")] 
		public HDRColor VolumetricParticleColor
		{
			get => GetProperty(ref _volumetricParticleColor);
			set => SetProperty(ref _volumetricParticleColor, value);
		}

		[Ordinal(34)] 
		[RED("volumetricParticleSize")] 
		public CFloat VolumetricParticleSize
		{
			get => GetProperty(ref _volumetricParticleSize);
			set => SetProperty(ref _volumetricParticleSize, value);
		}

		[Ordinal(35)] 
		[RED("volumetricParticleDensity")] 
		public CFloat VolumetricParticleDensity
		{
			get => GetProperty(ref _volumetricParticleDensity);
			set => SetProperty(ref _volumetricParticleDensity, value);
		}

		[Ordinal(36)] 
		[RED("volumetricParticleFalloff")] 
		public CFloat VolumetricParticleFalloff
		{
			get => GetProperty(ref _volumetricParticleFalloff);
			set => SetProperty(ref _volumetricParticleFalloff, value);
		}

		[Ordinal(37)] 
		[RED("volumetricParticleNoiseScale")] 
		public CFloat VolumetricParticleNoiseScale
		{
			get => GetProperty(ref _volumetricParticleNoiseScale);
			set => SetProperty(ref _volumetricParticleNoiseScale, value);
		}

		[Ordinal(38)] 
		[RED("volumetricParticleNoiseThreshold")] 
		public CFloat VolumetricParticleNoiseThreshold
		{
			get => GetProperty(ref _volumetricParticleNoiseThreshold);
			set => SetProperty(ref _volumetricParticleNoiseThreshold, value);
		}

		[Ordinal(39)] 
		[RED("volumetricParticleNoiseVelocity")] 
		public Vector3 VolumetricParticleNoiseVelocity
		{
			get => GetProperty(ref _volumetricParticleNoiseVelocity);
			set => SetProperty(ref _volumetricParticleNoiseVelocity, value);
		}

		public rendRenderParticleBlobEmitterInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
