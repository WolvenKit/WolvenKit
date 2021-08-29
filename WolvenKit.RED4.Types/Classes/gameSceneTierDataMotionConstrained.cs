using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSceneTierDataMotionConstrained : gameSceneTierData
	{
		private gameMotionConstrainedTierDataParams _params;

		[Ordinal(2)] 
		[RED("params")] 
		public gameMotionConstrainedTierDataParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
