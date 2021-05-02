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
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public scnCheckPlayerTargetNodeDistanceInterruptCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
