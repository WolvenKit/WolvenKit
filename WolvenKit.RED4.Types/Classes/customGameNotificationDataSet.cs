using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class customGameNotificationDataSet : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("customText")] 
		public CName CustomText
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("testBool")] 
		public CBool TestBool
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public customGameNotificationDataSet()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
