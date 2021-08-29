using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApartmentScreen : LcdScreen
	{
		private CUInt32 _timeSystemCallbackID;

		[Ordinal(99)] 
		[RED("timeSystemCallbackID")] 
		public CUInt32 TimeSystemCallbackID
		{
			get => GetProperty(ref _timeSystemCallbackID);
			set => SetProperty(ref _timeSystemCallbackID, value);
		}
	}
}
