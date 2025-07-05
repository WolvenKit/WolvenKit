using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StopPingingNetworkRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<gameObject> Source
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("pingData")] 
		public CHandle<PingCachedData> PingData
		{
			get => GetPropertyValue<CHandle<PingCachedData>>();
			set => SetPropertyValue<CHandle<PingCachedData>>(value);
		}

		public StopPingingNetworkRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
