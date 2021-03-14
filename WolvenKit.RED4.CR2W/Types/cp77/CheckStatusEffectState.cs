using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckStatusEffectState : AIStatusEffectCondition
	{
		private CEnum<gamedataStatusEffectType> _statusEffectType;
		private CEnum<EstatusEffectsState> _stateToCheck;
		private CHandle<gameStatusEffect> _topPrioStatusEffect;

		[Ordinal(0)] 
		[RED("statusEffectType")] 
		public CEnum<gamedataStatusEffectType> StatusEffectType
		{
			get
			{
				if (_statusEffectType == null)
				{
					_statusEffectType = (CEnum<gamedataStatusEffectType>) CR2WTypeManager.Create("gamedataStatusEffectType", "statusEffectType", cr2w, this);
				}
				return _statusEffectType;
			}
			set
			{
				if (_statusEffectType == value)
				{
					return;
				}
				_statusEffectType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stateToCheck")] 
		public CEnum<EstatusEffectsState> StateToCheck
		{
			get
			{
				if (_stateToCheck == null)
				{
					_stateToCheck = (CEnum<EstatusEffectsState>) CR2WTypeManager.Create("EstatusEffectsState", "stateToCheck", cr2w, this);
				}
				return _stateToCheck;
			}
			set
			{
				if (_stateToCheck == value)
				{
					return;
				}
				_stateToCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("topPrioStatusEffect")] 
		public CHandle<gameStatusEffect> TopPrioStatusEffect
		{
			get
			{
				if (_topPrioStatusEffect == null)
				{
					_topPrioStatusEffect = (CHandle<gameStatusEffect>) CR2WTypeManager.Create("handle:gameStatusEffect", "topPrioStatusEffect", cr2w, this);
				}
				return _topPrioStatusEffect;
			}
			set
			{
				if (_topPrioStatusEffect == value)
				{
					return;
				}
				_topPrioStatusEffect = value;
				PropertySet(this);
			}
		}

		public CheckStatusEffectState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
