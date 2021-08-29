using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemappinsDistrictEnteredEvent : gameScriptableSystemRequest
	{
		private CBool _entered;
		private CBool _sendNewLocationNotification;
		private TweakDBID _district;

		[Ordinal(0)] 
		[RED("entered")] 
		public CBool Entered
		{
			get => GetProperty(ref _entered);
			set => SetProperty(ref _entered, value);
		}

		[Ordinal(1)] 
		[RED("sendNewLocationNotification")] 
		public CBool SendNewLocationNotification
		{
			get => GetProperty(ref _sendNewLocationNotification);
			set => SetProperty(ref _sendNewLocationNotification, value);
		}

		[Ordinal(2)] 
		[RED("district")] 
		public TweakDBID District
		{
			get => GetProperty(ref _district);
			set => SetProperty(ref _district, value);
		}
	}
}
