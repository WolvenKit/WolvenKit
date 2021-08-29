using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldLocationAreaNotifier : worldITriggerAreaNotifer
	{
		private TweakDBID _districtID;
		private CBool _sendNewLocationNotification;

		[Ordinal(3)] 
		[RED("districtID")] 
		public TweakDBID DistrictID
		{
			get => GetProperty(ref _districtID);
			set => SetProperty(ref _districtID, value);
		}

		[Ordinal(4)] 
		[RED("sendNewLocationNotification")] 
		public CBool SendNewLocationNotification
		{
			get => GetProperty(ref _sendNewLocationNotification);
			set => SetProperty(ref _sendNewLocationNotification, value);
		}
	}
}
