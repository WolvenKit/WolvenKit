using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckTriggerReturnCondition : scnIReturnCondition
	{
		private scnCheckTriggerReturnConditionParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckTriggerReturnConditionParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
