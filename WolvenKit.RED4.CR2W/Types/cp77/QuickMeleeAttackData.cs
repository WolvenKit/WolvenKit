using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickMeleeAttackData : CVariable
	{
		private CFloat _attackGameEffectDelay;
		private CFloat _attackGameEffectDuration;
		private CFloat _attackRange;
		private CBool _forcePlayerToStand;
		private CBool _shouldAdjust;
		private CFloat _adjustmentRange;
		private CFloat _adjustmentDuration;
		private CFloat _adjustmentRadius;
		private CName _adjustmentCurve;
		private CFloat _cooldown;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("attackGameEffectDelay")] 
		public CFloat AttackGameEffectDelay
		{
			get
			{
				if (_attackGameEffectDelay == null)
				{
					_attackGameEffectDelay = (CFloat) CR2WTypeManager.Create("Float", "attackGameEffectDelay", cr2w, this);
				}
				return _attackGameEffectDelay;
			}
			set
			{
				if (_attackGameEffectDelay == value)
				{
					return;
				}
				_attackGameEffectDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("attackGameEffectDuration")] 
		public CFloat AttackGameEffectDuration
		{
			get
			{
				if (_attackGameEffectDuration == null)
				{
					_attackGameEffectDuration = (CFloat) CR2WTypeManager.Create("Float", "attackGameEffectDuration", cr2w, this);
				}
				return _attackGameEffectDuration;
			}
			set
			{
				if (_attackGameEffectDuration == value)
				{
					return;
				}
				_attackGameEffectDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("attackRange")] 
		public CFloat AttackRange
		{
			get
			{
				if (_attackRange == null)
				{
					_attackRange = (CFloat) CR2WTypeManager.Create("Float", "attackRange", cr2w, this);
				}
				return _attackRange;
			}
			set
			{
				if (_attackRange == value)
				{
					return;
				}
				_attackRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("forcePlayerToStand")] 
		public CBool ForcePlayerToStand
		{
			get
			{
				if (_forcePlayerToStand == null)
				{
					_forcePlayerToStand = (CBool) CR2WTypeManager.Create("Bool", "forcePlayerToStand", cr2w, this);
				}
				return _forcePlayerToStand;
			}
			set
			{
				if (_forcePlayerToStand == value)
				{
					return;
				}
				_forcePlayerToStand = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("shouldAdjust")] 
		public CBool ShouldAdjust
		{
			get
			{
				if (_shouldAdjust == null)
				{
					_shouldAdjust = (CBool) CR2WTypeManager.Create("Bool", "shouldAdjust", cr2w, this);
				}
				return _shouldAdjust;
			}
			set
			{
				if (_shouldAdjust == value)
				{
					return;
				}
				_shouldAdjust = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("adjustmentRange")] 
		public CFloat AdjustmentRange
		{
			get
			{
				if (_adjustmentRange == null)
				{
					_adjustmentRange = (CFloat) CR2WTypeManager.Create("Float", "adjustmentRange", cr2w, this);
				}
				return _adjustmentRange;
			}
			set
			{
				if (_adjustmentRange == value)
				{
					return;
				}
				_adjustmentRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("adjustmentDuration")] 
		public CFloat AdjustmentDuration
		{
			get
			{
				if (_adjustmentDuration == null)
				{
					_adjustmentDuration = (CFloat) CR2WTypeManager.Create("Float", "adjustmentDuration", cr2w, this);
				}
				return _adjustmentDuration;
			}
			set
			{
				if (_adjustmentDuration == value)
				{
					return;
				}
				_adjustmentDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("adjustmentRadius")] 
		public CFloat AdjustmentRadius
		{
			get
			{
				if (_adjustmentRadius == null)
				{
					_adjustmentRadius = (CFloat) CR2WTypeManager.Create("Float", "adjustmentRadius", cr2w, this);
				}
				return _adjustmentRadius;
			}
			set
			{
				if (_adjustmentRadius == value)
				{
					return;
				}
				_adjustmentRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("adjustmentCurve")] 
		public CName AdjustmentCurve
		{
			get
			{
				if (_adjustmentCurve == null)
				{
					_adjustmentCurve = (CName) CR2WTypeManager.Create("CName", "adjustmentCurve", cr2w, this);
				}
				return _adjustmentCurve;
			}
			set
			{
				if (_adjustmentCurve == value)
				{
					return;
				}
				_adjustmentCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get
			{
				if (_cooldown == null)
				{
					_cooldown = (CFloat) CR2WTypeManager.Create("Float", "cooldown", cr2w, this);
				}
				return _cooldown;
			}
			set
			{
				if (_cooldown == value)
				{
					return;
				}
				_cooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		public QuickMeleeAttackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
