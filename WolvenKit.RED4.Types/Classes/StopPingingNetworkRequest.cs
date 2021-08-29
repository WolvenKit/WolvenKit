using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StopPingingNetworkRequest : gameScriptableSystemRequest
	{
		private CWeakHandle<gameObject> _source;
		private CHandle<PingCachedData> _pingData;

		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<gameObject> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("pingData")] 
		public CHandle<PingCachedData> PingData
		{
			get => GetProperty(ref _pingData);
			set => SetProperty(ref _pingData, value);
		}
	}
}
