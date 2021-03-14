using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickMeleeEvents : WeaponEventsTransition
	{
		private CHandle<gameEffectInstance> _gameEffect;
		private wCHandle<gameObject> _targetObject;
		private CHandle<entIPlacedComponent> _targetComponent;
		private CBool _quickMeleeAttackCreated;
		private QuickMeleeAttackData _quickMeleeAttackData;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("targetObject")] 
		public wCHandle<gameObject> TargetObject
		{
			get
			{
				if (_targetObject == null)
				{
					_targetObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "targetObject", cr2w, this);
				}
				return _targetObject;
			}
			set
			{
				if (_targetObject == value)
				{
					return;
				}
				_targetObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetComponent")] 
		public CHandle<entIPlacedComponent> TargetComponent
		{
			get
			{
				if (_targetComponent == null)
				{
					_targetComponent = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "targetComponent", cr2w, this);
				}
				return _targetComponent;
			}
			set
			{
				if (_targetComponent == value)
				{
					return;
				}
				_targetComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("quickMeleeAttackCreated")] 
		public CBool QuickMeleeAttackCreated
		{
			get
			{
				if (_quickMeleeAttackCreated == null)
				{
					_quickMeleeAttackCreated = (CBool) CR2WTypeManager.Create("Bool", "quickMeleeAttackCreated", cr2w, this);
				}
				return _quickMeleeAttackCreated;
			}
			set
			{
				if (_quickMeleeAttackCreated == value)
				{
					return;
				}
				_quickMeleeAttackCreated = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("quickMeleeAttackData")] 
		public QuickMeleeAttackData QuickMeleeAttackData
		{
			get
			{
				if (_quickMeleeAttackData == null)
				{
					_quickMeleeAttackData = (QuickMeleeAttackData) CR2WTypeManager.Create("QuickMeleeAttackData", "quickMeleeAttackData", cr2w, this);
				}
				return _quickMeleeAttackData;
			}
			set
			{
				if (_quickMeleeAttackData == value)
				{
					return;
				}
				_quickMeleeAttackData = value;
				PropertySet(this);
			}
		}

		public QuickMeleeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
