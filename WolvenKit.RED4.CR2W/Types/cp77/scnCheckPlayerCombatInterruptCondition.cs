using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckPlayerCombatInterruptCondition : scnIInterruptCondition
	{
		private scnCheckPlayerCombatInterruptConditionParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckPlayerCombatInterruptConditionParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (scnCheckPlayerCombatInterruptConditionParams) CR2WTypeManager.Create("scnCheckPlayerCombatInterruptConditionParams", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public scnCheckPlayerCombatInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
