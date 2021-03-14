using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AOEArea : InteractiveMasterDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _areaComponent;
		private CHandle<gameEffectInstance> _gameEffect;
		private CBool _highLightActive;
		private CHandle<entIComponent> _visionBlockerComponent;
		private CHandle<gameinfluenceObstacleComponent> _obstacleComponent;
		private CArray<wCHandle<gamedataStatusEffect_Record>> _activeStatusEffects;
		private CFloat _extendPercentAABB;
		private CBool _isAABBExtended;

		[Ordinal(93)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get
			{
				if (_areaComponent == null)
				{
					_areaComponent = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "areaComponent", cr2w, this);
				}
				return _areaComponent;
			}
			set
			{
				if (_areaComponent == value)
				{
					return;
				}
				_areaComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("gameEffect")] 
		public CHandle<gameEffectInstance> GameEffect
		{
			get
			{
				if (_gameEffect == null)
				{
					_gameEffect = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "gameEffect", cr2w, this);
				}
				return _gameEffect;
			}
			set
			{
				if (_gameEffect == value)
				{
					return;
				}
				_gameEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("highLightActive")] 
		public CBool HighLightActive
		{
			get
			{
				if (_highLightActive == null)
				{
					_highLightActive = (CBool) CR2WTypeManager.Create("Bool", "highLightActive", cr2w, this);
				}
				return _highLightActive;
			}
			set
			{
				if (_highLightActive == value)
				{
					return;
				}
				_highLightActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("visionBlockerComponent")] 
		public CHandle<entIComponent> VisionBlockerComponent
		{
			get
			{
				if (_visionBlockerComponent == null)
				{
					_visionBlockerComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "visionBlockerComponent", cr2w, this);
				}
				return _visionBlockerComponent;
			}
			set
			{
				if (_visionBlockerComponent == value)
				{
					return;
				}
				_visionBlockerComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("obstacleComponent")] 
		public CHandle<gameinfluenceObstacleComponent> ObstacleComponent
		{
			get
			{
				if (_obstacleComponent == null)
				{
					_obstacleComponent = (CHandle<gameinfluenceObstacleComponent>) CR2WTypeManager.Create("handle:gameinfluenceObstacleComponent", "obstacleComponent", cr2w, this);
				}
				return _obstacleComponent;
			}
			set
			{
				if (_obstacleComponent == value)
				{
					return;
				}
				_obstacleComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("activeStatusEffects")] 
		public CArray<wCHandle<gamedataStatusEffect_Record>> ActiveStatusEffects
		{
			get
			{
				if (_activeStatusEffects == null)
				{
					_activeStatusEffects = (CArray<wCHandle<gamedataStatusEffect_Record>>) CR2WTypeManager.Create("array:whandle:gamedataStatusEffect_Record", "activeStatusEffects", cr2w, this);
				}
				return _activeStatusEffects;
			}
			set
			{
				if (_activeStatusEffects == value)
				{
					return;
				}
				_activeStatusEffects = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("extendPercentAABB")] 
		public CFloat ExtendPercentAABB
		{
			get
			{
				if (_extendPercentAABB == null)
				{
					_extendPercentAABB = (CFloat) CR2WTypeManager.Create("Float", "extendPercentAABB", cr2w, this);
				}
				return _extendPercentAABB;
			}
			set
			{
				if (_extendPercentAABB == value)
				{
					return;
				}
				_extendPercentAABB = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("isAABBExtended")] 
		public CBool IsAABBExtended
		{
			get
			{
				if (_isAABBExtended == null)
				{
					_isAABBExtended = (CBool) CR2WTypeManager.Create("Bool", "isAABBExtended", cr2w, this);
				}
				return _isAABBExtended;
			}
			set
			{
				if (_isAABBExtended == value)
				{
					return;
				}
				_isAABBExtended = value;
				PropertySet(this);
			}
		}

		public AOEArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
