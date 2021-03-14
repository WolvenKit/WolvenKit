using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckSpeakersDistanceReturnCondition : scnIReturnCondition
	{
		private scnCheckSpeakersDistanceReturnConditionParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckSpeakersDistanceReturnConditionParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (scnCheckSpeakersDistanceReturnConditionParams) CR2WTypeManager.Create("scnCheckSpeakersDistanceReturnConditionParams", "params", cr2w, this);
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

		public scnCheckSpeakersDistanceReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
