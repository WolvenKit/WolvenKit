using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckIntScenarioActiveReturnCondition : scnIReturnCondition
	{
		private scnCheckIntScenarioActiveReturnConditionParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckIntScenarioActiveReturnConditionParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
