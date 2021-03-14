using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckPlayerTargetNodeDistanceReturnCondition : scnIReturnCondition
	{
		private scnCheckPlayerTargetNodeDistanceReturnConditionParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckPlayerTargetNodeDistanceReturnConditionParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (scnCheckPlayerTargetNodeDistanceReturnConditionParams) CR2WTypeManager.Create("scnCheckPlayerTargetNodeDistanceReturnConditionParams", "params", cr2w, this);
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

		public scnCheckPlayerTargetNodeDistanceReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
