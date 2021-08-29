using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimetableCallbackData : IScriptable
	{
		private SSimpleGameTime _time;
		private CArray<RecipientData> _recipients;
		private CUInt32 _callbackID;

		[Ordinal(0)] 
		[RED("time")] 
		public SSimpleGameTime Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(1)] 
		[RED("recipients")] 
		public CArray<RecipientData> Recipients
		{
			get => GetProperty(ref _recipients);
			set => SetProperty(ref _recipients, value);
		}

		[Ordinal(2)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get => GetProperty(ref _callbackID);
			set => SetProperty(ref _callbackID, value);
		}
	}
}
