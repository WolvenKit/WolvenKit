using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LightSwitchRequest : redEvent
	{
		private CInt32 _requestNumber;

		[Ordinal(0)] 
		[RED("requestNumber")] 
		public CInt32 RequestNumber
		{
			get => GetProperty(ref _requestNumber);
			set => SetProperty(ref _requestNumber, value);
		}
	}
}
