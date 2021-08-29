using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RecurrentStimuliEvent : redEvent
	{
		private StimRequestID _requestID;

		[Ordinal(0)] 
		[RED("requestID")] 
		public StimRequestID RequestID
		{
			get => GetProperty(ref _requestID);
			set => SetProperty(ref _requestID, value);
		}
	}
}
