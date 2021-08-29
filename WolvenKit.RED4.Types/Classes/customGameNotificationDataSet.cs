using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class customGameNotificationDataSet : inkGameNotificationData
	{
		private CName _customText;
		private CBool _testBool;

		[Ordinal(6)] 
		[RED("customText")] 
		public CName CustomText
		{
			get => GetProperty(ref _customText);
			set => SetProperty(ref _customText, value);
		}

		[Ordinal(7)] 
		[RED("testBool")] 
		public CBool TestBool
		{
			get => GetProperty(ref _testBool);
			set => SetProperty(ref _testBool, value);
		}
	}
}
