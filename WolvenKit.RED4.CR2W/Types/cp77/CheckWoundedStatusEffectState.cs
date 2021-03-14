using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckWoundedStatusEffectState : AIStatusEffectCondition
	{
		private CEnum<EstatusEffectsState> _stateToCheck;

		[Ordinal(0)] 
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

		public CheckWoundedStatusEffectState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
