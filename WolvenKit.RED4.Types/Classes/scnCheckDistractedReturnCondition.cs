using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckDistractedReturnCondition : scnIReturnCondition
	{
		private scnCheckDistractedReturnConditionParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckDistractedReturnConditionParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
