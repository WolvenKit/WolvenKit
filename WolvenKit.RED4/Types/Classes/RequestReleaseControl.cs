using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequestReleaseControl : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("followupEvent")] 
		public CHandle<redEvent> FollowupEvent
		{
			get => GetPropertyValue<CHandle<redEvent>>();
			set => SetPropertyValue<CHandle<redEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("followupEventEntityID")] 
		public entEntityID FollowupEventEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public RequestReleaseControl()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
