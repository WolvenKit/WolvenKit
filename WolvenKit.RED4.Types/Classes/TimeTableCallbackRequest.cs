using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimeTableCallbackRequest : gameScriptableSystemRequest
	{
		private CUInt32 _callBackID;

		[Ordinal(0)] 
		[RED("callBackID")] 
		public CUInt32 CallBackID
		{
			get => GetProperty(ref _callBackID);
			set => SetProperty(ref _callBackID, value);
		}
	}
}
