using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleEmitter : IParticleModule
	{
		private CArray<CHandle<IParticleModule>> _modules;
		private CInt32 _positionX;
		private CInt32 _positionY;
		private rRef<IMaterial> _material;
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
			get
			{
				if (_modules == null)
				{
					_modules = (CArray<CHandle<IParticleModule>>) CR2WTypeManager.Create("array:handle:IParticleModule", "modules", cr2w, this);
				}
				return _modules;
			}
			set
			{
				if (_modules == value)
				{
					return;
				}
				_modules = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("positionX")] 
		public CInt32 PositionX
		{
			get
			{
				if (_positionX == null)
				{
					_positionX = (CInt32) CR2WTypeManager.Create("Int32", "positionX", cr2w, this);
				}
				return _positionX;
			}
			set
			{
				if (_positionX == value)
				{
					return;
				}
				_positionX = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("positionY")] 
		public CInt32 PositionY
		{
			get
			{
				if (_positionY == null)
				{
					_positionY = (CInt32) CR2WTypeManager.Create("Int32", "positionY", cr2w, this);
				}
				return _positionY;
			}
			set
			{
				if (_positionY == value)
				{
					return;
				}
				_positionY = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("material")] 
		public rRef<IMaterial> Material
		{
			get
			{
				if (_material == null)
				{
					_material = (rRef<IMaterial>) CR2WTypeManager.Create("rRef:IMaterial", "material", cr2w, this);
				}
				return _material;
			}
			set
			{
				if (_material == value)
				{
					return;
				}
				_material = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("localMaterialInstance")] 
		public CHandle<IMaterial> LocalMaterialInstance
		{
			get
			{
				if (_localMaterialInstance == null)
				{
					_localMaterialInstance = (CHandle<IMaterial>) CR2WTypeManager.Create("handle:IMaterial", "localMaterialInstance", cr2w, this);
				}
				return _localMaterialInstance;
			}
			set
			{
				if (_localMaterialInstance == value)
				{
					return;
				}
				_localMaterialInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("maxParticles")] 
		public CUInt16 MaxParticles
		{
			get
			{
				if (_maxParticles == null)
				{
					_maxParticles = (CUInt16) CR2WTypeManager.Create("Uint16", "maxParticles", cr2w, this);
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("particleDrawer")] 
		public CHandle<IParticleDrawer> ParticleDrawer
		{
			get
			{
				if (_particleDrawer == null)
				{
					_particleDrawer = (CHandle<IParticleDrawer>) CR2WTypeManager.Create("handle:IParticleDrawer", "particleDrawer", cr2w, this);
				}
				return _particleDrawer;
			}
			set
			{
				if (_particleDrawer == value)
				{
					return;
				}
				_particleDrawer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("decalSpawner")] 
		public CHandle<CDecalSpawner> DecalSpawner
		{
			get
			{
				if (_decalSpawner == null)
				{
					_decalSpawner = (CHandle<CDecalSpawner>) CR2WTypeManager.Create("handle:CDecalSpawner", "decalSpawner", cr2w, this);
				}
				return _decalSpawner;
			}
			set
			{
				if (_decalSpawner == value)
				{
					return;
				}
				_decalSpawner = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
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

		[Ordinal(21)] 
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

		[Ordinal(22)] 
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

		[Ordinal(23)] 
		[RED("envColorGroup")] 
		public CEnum<EEnvColorGroup> EnvColorGroup
		{
			get
			{
				if (_envColorGroup == null)
				{
					_envColorGroup = (CEnum<EEnvColorGroup>) CR2WTypeManager.Create("EEnvColorGroup", "envColorGroup", cr2w, this);
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

		[Ordinal(24)] 
		[RED("emitterGroup")] 
		public CEnum<EEmitterGroup> EmitterGroup
		{
			get
			{
				if (_emitterGroup == null)
				{
					_emitterGroup = (CEnum<EEmitterGroup>) CR2WTypeManager.Create("EEmitterGroup", "emitterGroup", cr2w, this);
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

		[Ordinal(25)] 
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

		[Ordinal(26)] 
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

		[Ordinal(27)] 
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

		[Ordinal(28)] 
		[RED("lods")] 
		public CArray<SParticleEmitterLODLevel> Lods
		{
			get
			{
				if (_lods == null)
				{
					_lods = (CArray<SParticleEmitterLODLevel>) CR2WTypeManager.Create("array:SParticleEmitterLODLevel", "lods", cr2w, this);
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

		[Ordinal(29)] 
		[RED("renderResourceBlob")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlob
		{
			get
			{
				if (_renderResourceBlob == null)
				{
					_renderResourceBlob = (CHandle<IRenderResourceBlob>) CR2WTypeManager.Create("handle:IRenderResourceBlob", "renderResourceBlob", cr2w, this);
				}
				return _renderResourceBlob;
			}
			set
			{
				if (_renderResourceBlob == value)
				{
					return;
				}
				_renderResourceBlob = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("Enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "Enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("Relative")] 
		public CBool Relative
		{
			get
			{
				if (_relative == null)
				{
					_relative = (CBool) CR2WTypeManager.Create("Bool", "Relative", cr2w, this);
				}
				return _relative;
			}
			set
			{
				if (_relative == value)
				{
					return;
				}
				_relative = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("UseEnvironmentFogColor")] 
		public CBool UseEnvironmentFogColor
		{
			get
			{
				if (_useEnvironmentFogColor == null)
				{
					_useEnvironmentFogColor = (CBool) CR2WTypeManager.Create("Bool", "UseEnvironmentFogColor", cr2w, this);
				}
				return _useEnvironmentFogColor;
			}
			set
			{
				if (_useEnvironmentFogColor == value)
				{
					return;
				}
				_useEnvironmentFogColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("Color")] 
		public HDRColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (HDRColor) CR2WTypeManager.Create("HDRColor", "Color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("Size")] 
		public CFloat Size
		{
			get
			{
				if (_size == null)
				{
					_size = (CFloat) CR2WTypeManager.Create("Float", "Size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("Density")] 
		public CFloat Density
		{
			get
			{
				if (_density == null)
				{
					_density = (CFloat) CR2WTypeManager.Create("Float", "Density", cr2w, this);
				}
				return _density;
			}
			set
			{
				if (_density == value)
				{
					return;
				}
				_density = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("Falloff")] 
		public CFloat Falloff
		{
			get
			{
				if (_falloff == null)
				{
					_falloff = (CFloat) CR2WTypeManager.Create("Float", "Falloff", cr2w, this);
				}
				return _falloff;
			}
			set
			{
				if (_falloff == value)
				{
					return;
				}
				_falloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("NoiseScale")] 
		public CFloat NoiseScale
		{
			get
			{
				if (_noiseScale == null)
				{
					_noiseScale = (CFloat) CR2WTypeManager.Create("Float", "NoiseScale", cr2w, this);
				}
				return _noiseScale;
			}
			set
			{
				if (_noiseScale == value)
				{
					return;
				}
				_noiseScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("NoiseThreshold")] 
		public CFloat NoiseThreshold
		{
			get
			{
				if (_noiseThreshold == null)
				{
					_noiseThreshold = (CFloat) CR2WTypeManager.Create("Float", "NoiseThreshold", cr2w, this);
				}
				return _noiseThreshold;
			}
			set
			{
				if (_noiseThreshold == value)
				{
					return;
				}
				_noiseThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("NoiseVelocity")] 
		public Vector3 NoiseVelocity
		{
			get
			{
				if (_noiseVelocity == null)
				{
					_noiseVelocity = (Vector3) CR2WTypeManager.Create("Vector3", "NoiseVelocity", cr2w, this);
				}
				return _noiseVelocity;
			}
			set
			{
				if (_noiseVelocity == value)
				{
					return;
				}
				_noiseVelocity = value;
				PropertySet(this);
			}
		}

		public CParticleEmitter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
