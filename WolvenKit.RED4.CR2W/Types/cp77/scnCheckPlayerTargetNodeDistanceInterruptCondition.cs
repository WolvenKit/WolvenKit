using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckPlayerTargetNodeDistanceInterruptCondition : scnIInterruptCondition
	{
		private scnCheckPlayerTargetNodeDistanceInterruptConditionParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckPlayerTargetNodeDistanceInterruptConditionParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (scnCheckPlayerTargetNodeDistanceInterruptConditionParams) CR2WTypeManager.Create("scnCheckPlayerTargetNodeDistanceInterruptConditionParams", "params", cr2w, this);
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

		public scnCheckPlayerTargetNodeDistanceInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
