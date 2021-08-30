using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleEmitter : IParticleModule
	{
		private CArray<CHandle<IParticleModule>> _modules;
		private CInt32 _positionX;
		private CInt32 _positionY;
		private CResourceReference<IMaterial> _material;
		private CHandle<IMaterial> _localMaterialInstance;
		private CUInt16 _maxParticles;
		private CFloat _diffuseWrapFactor;
		private CFloat _backLightingFactor;
		private CUInt32 _lightingMipBias;
		private CInt8 _emitterLoops;
		private CHandle<IParticleDrawer> _particleDrawer;
		private CHandle<CDecalSpawner> _decalSpawner;
		private CBool _maskInsideCar;
		private CBool _maskInsideInterior;
		private CBool _maskAboveWater;
		private CBool _maskUnderWater;
		private CBool _useSubFrameEmission;
		private CBool _keepSimulationLocal;
		private CBool _killOnCollision;
		private CUInt8 _initialParticleCount;
		private CEnum<EEnvColorGroup> _envColorGroup;
		private CEnum<EEmitterGroup> _emitterGroup;
		private CEnum<ERenderObjectType> _renderObjectType;
		private CFloat _windInfluence;
		private CUInt8 _internalPriority;
		private CArray<SParticleEmitterLODLevel> _lods;
		private CHandle<IRenderResourceBlob> _renderResourceBlob;
		private CBool _enabled;
		private CBool _relative;
		private CBool _useEnvironmentFogColor;
		private HDRColor _color;
		private CFloat _size;
		private CFloat _density;
		private CFloat _falloff;
		private CFloat _noiseScale;
		private CFloat _noiseThreshold;
		private Vector3 _noiseVelocity;

		[Ordinal(3)] 
		[RED("modules")] 
		public CArray<CHandle<IParticleModule>> Modules
		{
			get => GetProperty(ref _modules);
			set => SetProperty(ref _modules, value);
		}

		[Ordinal(4)] 
		[RED("positionX")] 
		public CInt32 PositionX
		{
			get => GetProperty(ref _positionX);
			set => SetProperty(ref _positionX, value);
		}

		[Ordinal(5)] 
		[RED("positionY")] 
		public CInt32 PositionY
		{
			get => GetProperty(ref _positionY);
			set => SetProperty(ref _positionY, value);
		}

		[Ordinal(6)] 
		[RED("material")] 
		public CResourceReference<IMaterial> Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		[Ordinal(7)] 
		[RED("localMaterialInstance")] 
		public CHandle<IMaterial> LocalMaterialInstance
		{
			get => GetProperty(ref _localMaterialInstance);
			set => SetProperty(ref _localMaterialInstance, value);
		}

		[Ordinal(8)] 
		[RED("maxParticles")] 
		public CUInt16 MaxParticles
		{
			get => GetProperty(ref _maxParticles);
			set => SetProperty(ref _maxParticles, value);
		}

		[Ordinal(9)] 
		[RED("diffuseWrapFactor")] 
		public CFloat DiffuseWrapFactor
		{
			get => GetProperty(ref _diffuseWrapFactor);
			set => SetProperty(ref _diffuseWrapFactor, value);
		}

		[Ordinal(10)] 
		[RED("backLightingFactor")] 
		public CFloat BackLightingFactor
		{
			get => GetProperty(ref _backLightingFactor);
			set => SetProperty(ref _backLightingFactor, value);
		}

		[Ordinal(11)] 
		[RED("lightingMipBias")] 
		public CUInt32 LightingMipBias
		{
			get => GetProperty(ref _lightingMipBias);
			set => SetProperty(ref _lightingMipBias, value);
		}

		[Ordinal(12)] 
		[RED("emitterLoops")] 
		public CInt8 EmitterLoops
		{
			get => GetProperty(ref _emitterLoops);
			set => SetProperty(ref _emitterLoops, value);
		}

		[Ordinal(13)] 
		[RED("particleDrawer")] 
		public CHandle<IParticleDrawer> ParticleDrawer
		{
			get => GetProperty(ref _particleDrawer);
			set => SetProperty(ref _particleDrawer, value);
		}

		[Ordinal(14)] 
		[RED("decalSpawner")] 
		public CHandle<CDecalSpawner> DecalSpawner
		{
			get => GetProperty(ref _decalSpawner);
			set => SetProperty(ref _decalSpawner, value);
		}

		[Ordinal(15)] 
		[RED("maskInsideCar")] 
		public CBool MaskInsideCar
		{
			get => GetProperty(ref _maskInsideCar);
			set => SetProperty(ref _maskInsideCar, value);
		}

		[Ordinal(16)] 
		[RED("maskInsideInterior")] 
		public CBool MaskInsideInterior
		{
			get => GetProperty(ref _maskInsideInterior);
			set => SetProperty(ref _maskInsideInterior, value);
		}

		[Ordinal(17)] 
		[RED("maskAboveWater")] 
		public CBool MaskAboveWater
		{
			get => GetProperty(ref _maskAboveWater);
			set => SetProperty(ref _maskAboveWater, value);
		}

		[Ordinal(18)] 
		[RED("maskUnderWater")] 
		public CBool MaskUnderWater
		{
			get => GetProperty(ref _maskUnderWater);
			set => SetProperty(ref _maskUnderWater, value);
		}

		[Ordinal(19)] 
		[RED("useSubFrameEmission")] 
		public CBool UseSubFrameEmission
		{
			get => GetProperty(ref _useSubFrameEmission);
			set => SetProperty(ref _useSubFrameEmission, value);
		}

		[Ordinal(20)] 
		[RED("keepSimulationLocal")] 
		public CBool KeepSimulationLocal
		{
			get => GetProperty(ref _keepSimulationLocal);
			set => SetProperty(ref _keepSimulationLocal, value);
		}

		[Ordinal(21)] 
		[RED("killOnCollision")] 
		public CBool KillOnCollision
		{
			get => GetProperty(ref _killOnCollision);
			set => SetProperty(ref _killOnCollision, value);
		}

		[Ordinal(22)] 
		[RED("initialParticleCount")] 
		public CUInt8 InitialParticleCount
		{
			get => GetProperty(ref _initialParticleCount);
			set => SetProperty(ref _initialParticleCount, value);
		}

		[Ordinal(23)] 
		[RED("envColorGroup")] 
		public CEnum<EEnvColorGroup> EnvColorGroup
		{
			get => GetProperty(ref _envColorGroup);
			set => SetProperty(ref _envColorGroup, value);
		}

		[Ordinal(24)] 
		[RED("emitterGroup")] 
		public CEnum<EEmitterGroup> EmitterGroup
		{
			get => GetProperty(ref _emitterGroup);
			set => SetProperty(ref _emitterGroup, value);
		}

		[Ordinal(25)] 
		[RED("renderObjectType")] 
		public CEnum<ERenderObjectType> RenderObjectType
		{
			get => GetProperty(ref _renderObjectType);
			set => SetProperty(ref _renderObjectType, value);
		}

		[Ordinal(26)] 
		[RED("windInfluence")] 
		public CFloat WindInfluence
		{
			get => GetProperty(ref _windInfluence);
			set => SetProperty(ref _windInfluence, value);
		}

		[Ordinal(27)] 
		[RED("internalPriority")] 
		public CUInt8 InternalPriority
		{
			get => GetProperty(ref _internalPriority);
			set => SetProperty(ref _internalPriority, value);
		}

		[Ordinal(28)] 
		[RED("lods")] 
		public CArray<SParticleEmitterLODLevel> Lods
		{
			get => GetProperty(ref _lods);
			set => SetProperty(ref _lods, value);
		}

		[Ordinal(29)] 
		[RED("renderResourceBlob")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlob
		{
			get => GetProperty(ref _renderResourceBlob);
			set => SetProperty(ref _renderResourceBlob, value);
		}

		[Ordinal(30)] 
		[RED("Enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(31)] 
		[RED("Relative")] 
		public CBool Relative
		{
			get => GetProperty(ref _relative);
			set => SetProperty(ref _relative, value);
		}

		[Ordinal(32)] 
		[RED("UseEnvironmentFogColor")] 
		public CBool UseEnvironmentFogColor
		{
			get => GetProperty(ref _useEnvironmentFogColor);
			set => SetProperty(ref _useEnvironmentFogColor, value);
		}

		[Ordinal(33)] 
		[RED("Color")] 
		public HDRColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(34)] 
		[RED("Size")] 
		public CFloat Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(35)] 
		[RED("Density")] 
		public CFloat Density
		{
			get => GetProperty(ref _density);
			set => SetProperty(ref _density, value);
		}

		[Ordinal(36)] 
		[RED("Falloff")] 
		public CFloat Falloff
		{
			get => GetProperty(ref _falloff);
			set => SetProperty(ref _falloff, value);
		}

		[Ordinal(37)] 
		[RED("NoiseScale")] 
		public CFloat NoiseScale
		{
			get => GetProperty(ref _noiseScale);
			set => SetProperty(ref _noiseScale, value);
		}

		[Ordinal(38)] 
		[RED("NoiseThreshold")] 
		public CFloat NoiseThreshold
		{
			get => GetProperty(ref _noiseThreshold);
			set => SetProperty(ref _noiseThreshold, value);
		}

		[Ordinal(39)] 
		[RED("NoiseVelocity")] 
		public Vector3 NoiseVelocity
		{
			get => GetProperty(ref _noiseVelocity);
			set => SetProperty(ref _noiseVelocity, value);
		}

		public CParticleEmitter()
		{
			_maxParticles = 55;
			_diffuseWrapFactor = 0.650000F;
			_backLightingFactor = 0.500000F;
			_renderObjectType = new() { Value = Enums.ERenderObjectType.ROT_Particle };
			_size = 1.000000F;
			_density = 1.000000F;
			_falloff = 1.000000F;
			_noiseScale = 1.000000F;
		}
	}
}
