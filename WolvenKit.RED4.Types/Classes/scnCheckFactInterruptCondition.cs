using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckFactInterruptCondition : scnIInterruptCondition
	{
		private scnCheckFactInterruptConditionParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckFactInterruptConditionParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
