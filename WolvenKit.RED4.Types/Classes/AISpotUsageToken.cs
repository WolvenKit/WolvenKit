using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISpotUsageToken : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("usedSpotId")] 
		public worldGlobalNodeID UsedSpotId
		{
			get => GetPropertyValue<worldGlobalNodeID>();
			set => SetPropertyValue<worldGlobalNodeID>(value);
		}

		[Ordinal(1)] 
		[RED("spotUserId")] 
		public entEntityID SpotUserId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public AISpotUsageToken()
		{
			UsedSpotId = new();
			SpotUserId = new();
		}
	}
}
