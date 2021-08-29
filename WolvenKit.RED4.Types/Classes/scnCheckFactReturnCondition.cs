using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckFactReturnCondition : scnIReturnCondition
	{
		private scnCheckFactReturnConditionParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckFactReturnConditionParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
