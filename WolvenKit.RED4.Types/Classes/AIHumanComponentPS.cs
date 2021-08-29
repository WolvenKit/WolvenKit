using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIHumanComponentPS : AICommandQueuePS
	{
		private AISpotUsageToken _spotUsageToken;

		[Ordinal(2)] 
		[RED("spotUsageToken")] 
		public AISpotUsageToken SpotUsageToken
		{
			get => GetProperty(ref _spotUsageToken);
			set => SetProperty(ref _spotUsageToken, value);
		}
	}
}
