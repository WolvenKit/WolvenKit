using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RealTimeUpdateRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("evt")] 
		public CHandle<gameTickableEvent> Evt
		{
			get => GetPropertyValue<CHandle<gameTickableEvent>>();
			set => SetPropertyValue<CHandle<gameTickableEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public RealTimeUpdateRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
