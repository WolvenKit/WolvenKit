using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ComputerSetup : TerminalSetup
	{
		[Ordinal(5)] 
		[RED("startingMenu")] 
		public CEnum<EComputerMenuType> StartingMenu
		{
			get => GetPropertyValue<CEnum<EComputerMenuType>>();
			set => SetPropertyValue<CEnum<EComputerMenuType>>(value);
		}

		[Ordinal(6)] 
		[RED("mailsMenu")] 
		public CBool MailsMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("filesMenu")] 
		public CBool FilesMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("systemMenu")] 
		public CBool SystemMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("internetMenu")] 
		public CBool InternetMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("newsFeedMenu")] 
		public CBool NewsFeedMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("mailsStructure")] 
		public CArray<gamedeviceGenericDataContent> MailsStructure
		{
			get => GetPropertyValue<CArray<gamedeviceGenericDataContent>>();
			set => SetPropertyValue<CArray<gamedeviceGenericDataContent>>(value);
		}

		[Ordinal(12)] 
		[RED("filesStructure")] 
		public CArray<gamedeviceGenericDataContent> FilesStructure
		{
			get => GetPropertyValue<CArray<gamedeviceGenericDataContent>>();
			set => SetPropertyValue<CArray<gamedeviceGenericDataContent>>(value);
		}

		[Ordinal(13)] 
		[RED("newsFeed")] 
		public CArray<SNewsFeedElementData> NewsFeed
		{
			get => GetPropertyValue<CArray<SNewsFeedElementData>>();
			set => SetPropertyValue<CArray<SNewsFeedElementData>>(value);
		}

		[Ordinal(14)] 
		[RED("newsFeedInterval")] 
		public CFloat NewsFeedInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("internetSubnet")] 
		public SInternetData InternetSubnet
		{
			get => GetPropertyValue<SInternetData>();
			set => SetPropertyValue<SInternetData>(value);
		}

		[Ordinal(16)] 
		[RED("animationState")] 
		public CEnum<EComputerAnimationState> AnimationState
		{
			get => GetPropertyValue<CEnum<EComputerAnimationState>>();
			set => SetPropertyValue<CEnum<EComputerAnimationState>>(value);
		}

		public ComputerSetup()
		{
			MailsMenu = true;
			FilesMenu = true;
			SystemMenu = true;
			InternetMenu = true;
			MailsStructure = new();
			FilesStructure = new();
			NewsFeed = new();
			NewsFeedInterval = 5.000000F;
			InternetSubnet = new SInternetData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
