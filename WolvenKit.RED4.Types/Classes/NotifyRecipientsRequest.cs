using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NotifyRecipientsRequest : gameScriptableSystemRequest
	{
		private CArray<RecipientData> _recipients;
		private GameTime _time;

		[Ordinal(0)] 
		[RED("recipients")] 
		public CArray<RecipientData> Recipients
		{
			get => GetProperty(ref _recipients);
			set => SetProperty(ref _recipients, value);
		}

		[Ordinal(1)] 
		[RED("time")] 
		public GameTime Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}
	}
}
