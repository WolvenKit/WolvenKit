using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckPlayerCombatReturnCondition : scnIReturnCondition
	{
		private scnCheckPlayerCombatReturnConditionParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckPlayerCombatReturnConditionParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (scnCheckPlayerCombatReturnConditionParams) CR2WTypeManager.Create("scnCheckPlayerCombatReturnConditionParams", "params", cr2w, this);
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

		public scnCheckPlayerCombatReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
