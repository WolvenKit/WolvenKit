using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleSystem : resStreamedResource
	{
		private CBool _visibleThroughWalls;
		private CFloat _prewarmingTime;
		private CArray<CHandle<CParticleEmitter>> _emitters;
		private Box _boundingBox;
		private CBool _forceDynamicBbox;
		private CFloat _autoHideDistance;
		private CFloat _autoHideRange;
		private CFloat _lastLODFadeoutRange;
		private CEnum<ERenderingPlane> _renderingPlane;
		private CHandle<ParticleDamage> _particleDamage;

		[Ordinal(1)] 
		[RED("visibleThroughWalls")] 
		public CBool VisibleThroughWalls
		{
			get
			{
				if (_visibleThroughWalls == null)
				{
					_visibleThroughWalls = (CBool) CR2WTypeManager.Create("Bool", "visibleThroughWalls", cr2w, this);
				}
				return _visibleThroughWalls;
			}
			set
			{
				if (_visibleThroughWalls == value)
				{
					return;
				}
				_visibleThroughWalls = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("prewarmingTime")] 
		public CFloat PrewarmingTime
		{
			get
			{
				if (_prewarmingTime == null)
				{
					_prewarmingTime = (CFloat) CR2WTypeManager.Create("Float", "prewarmingTime", cr2w, this);
				}
				return _prewarmingTime;
			}
			set
			{
				if (_prewarmingTime == value)
				{
					return;
				}
				_prewarmingTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("emitters")] 
		public CArray<CHandle<CParticleEmitter>> Emitters
		{
			get
			{
				if (_emitters == null)
				{
					_emitters = (CArray<CHandle<CParticleEmitter>>) CR2WTypeManager.Create("array:handle:CParticleEmitter", "emitters", cr2w, this);
				}
				return _emitters;
			}
			set
			{
				if (_emitters == value)
				{
					return;
				}
				_emitters = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get
			{
				if (_boundingBox == null)
				{
					_boundingBox = (Box) CR2WTypeManager.Create("Box", "boundingBox", cr2w, this);
				}
				return _boundingBox;
			}
			set
			{
				if (_boundingBox == value)
				{
					return;
				}
				_boundingBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("forceDynamicBbox")] 
		public CBool ForceDynamicBbox
		{
			get
			{
				if (_forceDynamicBbox == null)
				{
					_forceDynamicBbox = (CBool) CR2WTypeManager.Create("Bool", "forceDynamicBbox", cr2w, this);
				}
				return _forceDynamicBbox;
			}
			set
			{
				if (_forceDynamicBbox == value)
				{
					return;
				}
				_forceDynamicBbox = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("autoHideDistance")] 
		public CFloat AutoHideDistance
		{
			get
			{
				if (_autoHideDistance == null)
				{
					_autoHideDistance = (CFloat) CR2WTypeManager.Create("Float", "autoHideDistance", cr2w, this);
				}
				return _autoHideDistance;
			}
			set
			{
				if (_autoHideDistance == value)
				{
					return;
				}
				_autoHideDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("autoHideRange")] 
		public CFloat AutoHideRange
		{
			get
			{
				if (_autoHideRange == null)
				{
					_autoHideRange = (CFloat) CR2WTypeManager.Create("Float", "autoHideRange", cr2w, this);
				}
				return _autoHideRange;
			}
			set
			{
				if (_autoHideRange == value)
				{
					return;
				}
				_autoHideRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("lastLODFadeoutRange")] 
		public CFloat LastLODFadeoutRange
		{
			get
			{
				if (_lastLODFadeoutRange == null)
				{
					_lastLODFadeoutRange = (CFloat) CR2WTypeManager.Create("Float", "lastLODFadeoutRange", cr2w, this);
				}
				return _lastLODFadeoutRange;
			}
			set
			{
				if (_lastLODFadeoutRange == value)
				{
					return;
				}
				_lastLODFadeoutRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("renderingPlane")] 
		public CEnum<ERenderingPlane> RenderingPlane
		{
			get
			{
				if (_renderingPlane == null)
				{
					_renderingPlane = (CEnum<ERenderingPlane>) CR2WTypeManager.Create("ERenderingPlane", "renderingPlane", cr2w, this);
				}
				return _renderingPlane;
			}
			set
			{
				if (_renderingPlane == value)
				{
					return;
				}
				_renderingPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("particleDamage")] 
		public CHandle<ParticleDamage> ParticleDamage
		{
			get
			{
				if (_particleDamage == null)
				{
					_particleDamage = (CHandle<ParticleDamage>) CR2WTypeManager.Create("handle:ParticleDamage", "particleDamage", cr2w, this);
				}
				return _particleDamage;
			}
			set
			{
				if (_particleDamage == value)
				{
					return;
				}
				_particleDamage = value;
				PropertySet(this);
			}
		}

		public CParticleSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
