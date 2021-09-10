using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class customGameNotificationDataSet : inkGameNotificationData
	{
		[Ordinal(6)] 
		[RED("customText")] 
		public CName CustomText
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("testBool")] 
		public CBool TestBool
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
