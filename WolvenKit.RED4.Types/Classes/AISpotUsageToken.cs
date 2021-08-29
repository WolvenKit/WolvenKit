using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISpotUsageToken : RedBaseClass
	{
		private worldGlobalNodeID _usedSpotId;
		private entEntityID _spotUserId;

		[Ordinal(0)] 
		[RED("usedSpotId")] 
		public worldGlobalNodeID UsedSpotId
		{
			get => GetProperty(ref _usedSpotId);
			set => SetProperty(ref _usedSpotId, value);
		}

		[Ordinal(1)] 
		[RED("spotUserId")] 
		public entEntityID SpotUserId
		{
			get => GetProperty(ref _spotUserId);
			set => SetProperty(ref _spotUserId, value);
		}
	}
}
