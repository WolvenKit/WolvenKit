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
			get
			{
				if (_emitterHash == null)
				{
					_emitterHash = (CUInt64) CR2WTypeManager.Create("Uint64", "emitterHash", cr2w, this);
				}
				return _emitterHash;
			}
			set
			{
				if (_emitterHash == value)
				{
					return;
				}
				_emitterHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("diffuseWrapFactor")] 
		public CFloat DiffuseWrapFactor
		{
			get
			{
				if (_diffuseWrapFactor == null)
				{
					_diffuseWrapFactor = (CFloat) CR2WTypeManager.Create("Float", "diffuseWrapFactor", cr2w, this);
				}
				return _diffuseWrapFactor;
			}
			set
			{
				if (_diffuseWrapFactor == value)
				{
					return;
				}
				_diffuseWrapFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("backLightingFactor")] 
		public CFloat BackLightingFactor
		{
			get
			{
				if (_backLightingFactor == null)
				{
					_backLightingFactor = (CFloat) CR2WTypeManager.Create("Float", "backLightingFactor", cr2w, this);
				}
				return _backLightingFactor;
			}
			set
			{
				if (_backLightingFactor == value)
				{
					return;
				}
				_backLightingFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lightingMipBias")] 
		public CUInt32 LightingMipBias
		{
			get
			{
				if (_lightingMipBias == null)
				{
					_lightingMipBias = (CUInt32) CR2WTypeManager.Create("Uint32", "lightingMipBias", cr2w, this);
				}
				return _lightingMipBias;
			}
			set
			{
				if (_lightingMipBias == value)
				{
					return;
				}
				_lightingMipBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maskInsideCar")] 
		public CBool MaskInsideCar
		{
			get
			{
				if (_maskInsideCar == null)
				{
					_maskInsideCar = (CBool) CR2WTypeManager.Create("Bool", "maskInsideCar", cr2w, this);
				}
				return _maskInsideCar;
			}
			set
			{
				if (_maskInsideCar == value)
				{
					return;
				}
				_maskInsideCar = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maskInsideInterior")] 
		public CBool MaskInsideInterior
		{
			get
			{
				if (_maskInsideInterior == null)
				{
					_maskInsideInterior = (CBool) CR2WTypeManager.Create("Bool", "maskInsideInterior", cr2w, this);
				}
				return _maskInsideInterior;
			}
			set
			{
				if (_maskInsideInterior == value)
				{
					return;
				}
				_maskInsideInterior = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("maskAboveWater")] 
		public CBool MaskAboveWater
		{
			get
			{
				if (_maskAboveWater == null)
				{
					_maskAboveWater = (CBool) CR2WTypeManager.Create("Bool", "maskAboveWater", cr2w, this);
				}
				return _maskAboveWater;
			}
			set
			{
				if (_maskAboveWater == value)
				{
					return;
				}
				_maskAboveWater = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maskUnderWater")] 
		public CBool MaskUnderWater
		{
			get
			{
				if (_maskUnderWater == null)
				{
					_maskUnderWater = (CBool) CR2WTypeManager.Create("Bool", "maskUnderWater", cr2w, this);
				}
				return _maskUnderWater;
			}
			set
			{
				if (_maskUnderWater == value)
				{
					return;
				}
				_maskUnderWater = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("maxParticles")] 
		public CUInt32 MaxParticles
		{
			get
			{
				if (_maxParticles == null)
				{
					_maxParticles = (CUInt32) CR2WTypeManager.Create("Uint32", "maxParticles", cr2w, this);
				}
				return _maxParticles;
			}
			set
			{
				if (_maxParticles == value)
				{
					return;
				}
				_maxParticles = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("emitterLoops")] 
		public CInt8 EmitterLoops
		{
			get
			{
				if (_emitterLoops == null)
				{
					_emitterLoops = (CInt8) CR2WTypeManager.Create("Int8", "emitterLoops", cr2w, this);
				}
				return _emitterLoops;
			}
			set
			{
				if (_emitterLoops == value)
				{
					return;
				}
				_emitterLoops = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("internalPriority")] 
		public CUInt8 InternalPriority
		{
			get
			{
				if (_internalPriority == null)
				{
					_internalPriority = (CUInt8) CR2WTypeManager.Create("Uint8", "internalPriority", cr2w, this);
				}
				return _internalPriority;
			}
			set
			{
				if (_internalPriority == value)
				{
					return;
				}
				_internalPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("keepSimulationLocal")] 
		public CBool KeepSimulationLocal
		{
			get
			{
				if (_keepSimulationLocal == null)
				{
					_keepSimulationLocal = (CBool) CR2WTypeManager.Create("Bool", "keepSimulationLocal", cr2w, this);
				}
				return _keepSimulationLocal;
			}
			set
			{
				if (_keepSimulationLocal == value)
				{
					return;
				}
				_keepSimulationLocal = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("killOnCollision")] 
		public CBool KillOnCollision
		{
			get
			{
				if (_killOnCollision == null)
				{
					_killOnCollision = (CBool) CR2WTypeManager.Create("Bool", "killOnCollision", cr2w, this);
				}
				return _killOnCollision;
			}
			set
			{
				if (_killOnCollision == value)
				{
					return;
				}
				_killOnCollision = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("initialParticleCount")] 
		public CUInt8 InitialParticleCount
		{
			get
			{
				if (_initialParticleCount == null)
				{
					_initialParticleCount = (CUInt8) CR2WTypeManager.Create("Uint8", "initialParticleCount", cr2w, this);
				}
				return _initialParticleCount;
			}
			set
			{
				if (_initialParticleCount == value)
				{
					return;
				}
				_initialParticleCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("useSubFrameEmission")] 
		public CBool UseSubFrameEmission
		{
			get
			{
				if (_useSubFrameEmission == null)
				{
					_useSubFrameEmission = (CBool) CR2WTypeManager.Create("Bool", "useSubFrameEmission", cr2w, this);
				}
				return _useSubFrameEmission;
			}
			set
			{
				if (_useSubFrameEmission == value)
				{
					return;
				}
				_useSubFrameEmission = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("windInfluence")] 
		public CFloat WindInfluence
		{
			get
			{
				if (_windInfluence == null)
				{
					_windInfluence = (CFloat) CR2WTypeManager.Create("Float", "windInfluence", cr2w, this);
				}
				return _windInfluence;
			}
			set
			{
				if (_windInfluence == value)
				{
					return;
				}
				_windInfluence = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("particleType")] 
		public CUInt32 ParticleType
		{
			get
			{
				if (_particleType == null)
				{
					_particleType = (CUInt32) CR2WTypeManager.Create("Uint32", "particleType", cr2w, this);
				}
				return _particleType;
			}
			set
			{
				if (_particleType == value)
				{
					return;
				}
				_particleType = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("vertexDrawerType")] 
		public CUInt32 VertexDrawerType
		{
			get
			{
				if (_vertexDrawerType == null)
				{
					_vertexDrawerType = (CUInt32) CR2WTypeManager.Create("Uint32", "vertexDrawerType", cr2w, this);
				}
				return _vertexDrawerType;
			}
			set
			{
				if (_vertexDrawerType == value)
				{
					return;
				}
				_vertexDrawerType = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("simulationType")] 
		public CUInt32 SimulationType
		{
			get
			{
				if (_simulationType == null)
				{
					_simulationType = (CUInt32) CR2WTypeManager.Create("Uint32", "simulationType", cr2w, this);
				}
				return _simulationType;
			}
			set
			{
				if (_simulationType == value)
				{
					return;
				}
				_simulationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("envColorGroup")] 
		public CUInt32 EnvColorGroup
		{
			get
			{
				if (_envColorGroup == null)
				{
					_envColorGroup = (CUInt32) CR2WTypeManager.Create("Uint32", "envColorGroup", cr2w, this);
				}
				return _envColorGroup;
			}
			set
			{
				if (_envColorGroup == value)
				{
					return;
				}
				_envColorGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("emitterGroup")] 
		public CUInt32 EmitterGroup
		{
			get
			{
				if (_emitterGroup == null)
				{
					_emitterGroup = (CUInt32) CR2WTypeManager.Create("Uint32", "emitterGroup", cr2w, this);
				}
				return _emitterGroup;
			}
			set
			{
				if (_emitterGroup == value)
				{
					return;
				}
				_emitterGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("renderObjectType")] 
		public CEnum<ERenderObjectType> RenderObjectType
		{
			get
			{
				if (_renderObjectType == null)
				{
					_renderObjectType = (CEnum<ERenderObjectType>) CR2WTypeManager.Create("ERenderObjectType", "renderObjectType", cr2w, this);
				}
				return _renderObjectType;
			}
			set
			{
				if (_renderObjectType == value)
				{
					return;
				}
				_renderObjectType = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("numModifiers")] 
		public CUInt32 NumModifiers
		{
			get
			{
				if (_numModifiers == null)
				{
					_numModifiers = (CUInt32) CR2WTypeManager.Create("Uint32", "numModifiers", cr2w, this);
				}
				return _numModifiers;
			}
			set
			{
				if (_numModifiers == value)
				{
					return;
				}
				_numModifiers = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("modifierSetMask")] 
		public CUInt64 ModifierSetMask
		{
			get
			{
				if (_modifierSetMask == null)
				{
					_modifierSetMask = (CUInt64) CR2WTypeManager.Create("Uint64", "modifierSetMask", cr2w, this);
				}
				return _modifierSetMask;
			}
			set
			{
				if (_modifierSetMask == value)
				{
					return;
				}
				_modifierSetMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("numInitializers")] 
		public CUInt32 NumInitializers
		{
			get
			{
				if (_numInitializers == null)
				{
					_numInitializers = (CUInt32) CR2WTypeManager.Create("Uint32", "numInitializers", cr2w, this);
				}
				return _numInitializers;
			}
			set
			{
				if (_numInitializers == value)
				{
					return;
				}
				_numInitializers = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("initializerSetMask")] 
		public CUInt64 InitializerSetMask
		{
			get
			{
				if (_initializerSetMask == null)
				{
					_initializerSetMask = (CUInt64) CR2WTypeManager.Create("Uint64", "initializerSetMask", cr2w, this);
				}
				return _initializerSetMask;
			}
			set
			{
				if (_initializerSetMask == value)
				{
					return;
				}
				_initializerSetMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("simulationHash")] 
		public CUInt64 SimulationHash
		{
			get
			{
				if (_simulationHash == null)
				{
					_simulationHash = (CUInt64) CR2WTypeManager.Create("Uint64", "simulationHash", cr2w, this);
				}
				return _simulationHash;
			}
			set
			{
				if (_simulationHash == value)
				{
					return;
				}
				_simulationHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("eventSetMask")] 
		public CUInt16 EventSetMask
		{
			get
			{
				if (_eventSetMask == null)
				{
					_eventSetMask = (CUInt16) CR2WTypeManager.Create("Uint16", "eventSetMask", cr2w, this);
				}
				return _eventSetMask;
			}
			set
			{
				if (_eventSetMask == value)
				{
					return;
				}
				_eventSetMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("seeds")] 
		public CArray<CUInt32> Seeds
		{
			get
			{
				if (_seeds == null)
				{
					_seeds = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "seeds", cr2w, this);
				}
				return _seeds;
			}
			set
			{
				if (_seeds == value)
				{
					return;
				}
				_seeds = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("lods")] 
		public CArray<rendEmitterLOD> Lods
		{
			get
			{
				if (_lods == null)
				{
					_lods = (CArray<rendEmitterLOD>) CR2WTypeManager.Create("array:rendEmitterLOD", "lods", cr2w, this);
				}
				return _lods;
			}
			set
			{
				if (_lods == value)
				{
					return;
				}
				_lods = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("volumetricParticleEnabled")] 
		public CBool VolumetricParticleEnabled
		{
			get
			{
				if (_volumetricParticleEnabled == null)
				{
					_volumetricParticleEnabled = (CBool) CR2WTypeManager.Create("Bool", "volumetricParticleEnabled", cr2w, this);
				}
				return _volumetricParticleEnabled;
			}
			set
			{
				if (_volumetricParticleEnabled == value)
				{
					return;
				}
				_volumetricParticleEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("volumetricParticleRelative")] 
		public CBool VolumetricParticleRelative
		{
			get
			{
				if (_volumetricParticleRelative == null)
				{
					_volumetricParticleRelative = (CBool) CR2WTypeManager.Create("Bool", "volumetricParticleRelative", cr2w, this);
				}
				return _volumetricParticleRelative;
			}
			set
			{
				if (_volumetricParticleRelative == value)
				{
					return;
				}
				_volumetricParticleRelative = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("volumetricParticleUseFogColor")] 
		public CBool VolumetricParticleUseFogColor
		{
			get
			{
				if (_volumetricParticleUseFogColor == null)
				{
					_volumetricParticleUseFogColor = (CBool) CR2WTypeManager.Create("Bool", "volumetricParticleUseFogColor", cr2w, this);
				}
				return _volumetricParticleUseFogColor;
			}
			set
			{
				if (_volumetricParticleUseFogColor == value)
				{
					return;
				}
				_volumetricParticleUseFogColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("volumetricParticleColor")] 
		public HDRColor VolumetricParticleColor
		{
			get
			{
				if (_volumetricParticleColor == null)
				{
					_volumetricParticleColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "volumetricParticleColor", cr2w, this);
				}
				return _volumetricParticleColor;
			}
			set
			{
				if (_volumetricParticleColor == value)
				{
					return;
				}
				_volumetricParticleColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("volumetricParticleSize")] 
		public CFloat VolumetricParticleSize
		{
			get
			{
				if (_volumetricParticleSize == null)
				{
					_volumetricParticleSize = (CFloat) CR2WTypeManager.Create("Float", "volumetricParticleSize", cr2w, this);
				}
				return _volumetricParticleSize;
			}
			set
			{
				if (_volumetricParticleSize == value)
				{
					return;
				}
				_volumetricParticleSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("volumetricParticleDensity")] 
		public CFloat VolumetricParticleDensity
		{
			get
			{
				if (_volumetricParticleDensity == null)
				{
					_volumetricParticleDensity = (CFloat) CR2WTypeManager.Create("Float", "volumetricParticleDensity", cr2w, this);
				}
				return _volumetricParticleDensity;
			}
			set
			{
				if (_volumetricParticleDensity == value)
				{
					return;
				}
				_volumetricParticleDensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("volumetricParticleFalloff")] 
		public CFloat VolumetricParticleFalloff
		{
			get
			{
				if (_volumetricParticleFalloff == null)
				{
					_volumetricParticleFalloff = (CFloat) CR2WTypeManager.Create("Float", "volumetricParticleFalloff", cr2w, this);
				}
				return _volumetricParticleFalloff;
			}
			set
			{
				if (_volumetricParticleFalloff == value)
				{
					return;
				}
				_volumetricParticleFalloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("volumetricParticleNoiseScale")] 
		public CFloat VolumetricParticleNoiseScale
		{
			get
			{
				if (_volumetricParticleNoiseScale == null)
				{
					_volumetricParticleNoiseScale = (CFloat) CR2WTypeManager.Create("Float", "volumetricParticleNoiseScale", cr2w, this);
				}
				return _volumetricParticleNoiseScale;
			}
			set
			{
				if (_volumetricParticleNoiseScale == value)
				{
					return;
				}
				_volumetricParticleNoiseScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("volumetricParticleNoiseThreshold")] 
		public CFloat VolumetricParticleNoiseThreshold
		{
			get
			{
				if (_volumetricParticleNoiseThreshold == null)
				{
					_volumetricParticleNoiseThreshold = (CFloat) CR2WTypeManager.Create("Float", "volumetricParticleNoiseThreshold", cr2w, this);
				}
				return _volumetricParticleNoiseThreshold;
			}
			set
			{
				if (_volumetricParticleNoiseThreshold == value)
				{
					return;
				}
				_volumetricParticleNoiseThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("volumetricParticleNoiseVelocity")] 
		public Vector3 VolumetricParticleNoiseVelocity
		{
			get
			{
				if (_volumetricParticleNoiseVelocity == null)
				{
					_volumetricParticleNoiseVelocity = (Vector3) CR2WTypeManager.Create("Vector3", "volumetricParticleNoiseVelocity", cr2w, this);
				}
				return _volumetricParticleNoiseVelocity;
			}
			set
			{
				if (_volumetricParticleNoiseVelocity == value)
				{
					return;
				}
				_volumetricParticleNoiseVelocity = value;
				PropertySet(this);
			}
		}

		public rendRenderParticleBlobEmitterInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
