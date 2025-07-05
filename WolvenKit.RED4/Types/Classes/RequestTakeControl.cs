using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequestTakeControl : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("requestSource")] 
		public entEntityID RequestSource
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("originalEvent")] 
		public CHandle<ToggleTakeOverControl> OriginalEvent
		{
			get => GetPropertyValue<CHandle<ToggleTakeOverControl>>();
			set => SetPropertyValue<CHandle<ToggleTakeOverControl>>(value);
		}

		public RequestTakeControl()
		{
			RequestSource = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
