using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckTriggerInterruptCondition : scnIInterruptCondition
	{
		private scnCheckTriggerInterruptConditionParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckTriggerInterruptConditionParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
