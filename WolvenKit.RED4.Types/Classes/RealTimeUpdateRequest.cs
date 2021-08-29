using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RealTimeUpdateRequest : gameScriptableSystemRequest
	{
		private CHandle<gameTickableEvent> _evt;
		private CFloat _time;

		[Ordinal(0)] 
		[RED("evt")] 
		public CHandle<gameTickableEvent> Evt
		{
			get => GetProperty(ref _evt);
			set => SetProperty(ref _evt, value);
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}
	}
}
