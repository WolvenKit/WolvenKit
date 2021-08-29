using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ComputerSetup : TerminalSetup
	{
		private CEnum<EComputerMenuType> _startingMenu;
		private CBool _mailsMenu;
		private CBool _filesMenu;
		private CBool _systemMenu;
		private CBool _internetMenu;
		private CBool _newsFeedMenu;
		private CArray<gamedeviceGenericDataContent> _mailsStructure;
		private CArray<gamedeviceGenericDataContent> _filesStructure;
		private CArray<SNewsFeedElementData> _newsFeed;
		private CFloat _newsFeedInterval;
		private SInternetData _internetSubnet;
		private CEnum<EComputerAnimationState> _animationState;

		[Ordinal(4)] 
		[RED("startingMenu")] 
		public CEnum<EComputerMenuType> StartingMenu
		{
			get => GetProperty(ref _startingMenu);
			set => SetProperty(ref _startingMenu, value);
		}

		[Ordinal(5)] 
		[RED("mailsMenu")] 
		public CBool MailsMenu
		{
			get => GetProperty(ref _mailsMenu);
			set => SetProperty(ref _mailsMenu, value);
		}

		[Ordinal(6)] 
		[RED("filesMenu")] 
		public CBool FilesMenu
		{
			get => GetProperty(ref _filesMenu);
			set => SetProperty(ref _filesMenu, value);
		}

		[Ordinal(7)] 
		[RED("systemMenu")] 
		public CBool SystemMenu
		{
			get => GetProperty(ref _systemMenu);
			set => SetProperty(ref _systemMenu, value);
		}

		[Ordinal(8)] 
		[RED("internetMenu")] 
		public CBool InternetMenu
		{
			get => GetProperty(ref _internetMenu);
			set => SetProperty(ref _internetMenu, value);
		}

		[Ordinal(9)] 
		[RED("newsFeedMenu")] 
		public CBool NewsFeedMenu
		{
			get => GetProperty(ref _newsFeedMenu);
			set => SetProperty(ref _newsFeedMenu, value);
		}

		[Ordinal(10)] 
		[RED("mailsStructure")] 
		public CArray<gamedeviceGenericDataContent> MailsStructure
		{
			get => GetProperty(ref _mailsStructure);
			set => SetProperty(ref _mailsStructure, value);
		}

		[Ordinal(11)] 
		[RED("filesStructure")] 
		public CArray<gamedeviceGenericDataContent> FilesStructure
		{
			get => GetProperty(ref _filesStructure);
			set => SetProperty(ref _filesStructure, value);
		}

		[Ordinal(12)] 
		[RED("newsFeed")] 
		public CArray<SNewsFeedElementData> NewsFeed
		{
			get => GetProperty(ref _newsFeed);
			set => SetProperty(ref _newsFeed, value);
		}

		[Ordinal(13)] 
		[RED("newsFeedInterval")] 
		public CFloat NewsFeedInterval
		{
			get => GetProperty(ref _newsFeedInterval);
			set => SetProperty(ref _newsFeedInterval, value);
		}

		[Ordinal(14)] 
		[RED("internetSubnet")] 
		public SInternetData InternetSubnet
		{
			get => GetProperty(ref _internetSubnet);
			set => SetProperty(ref _internetSubnet, value);
		}

		[Ordinal(15)] 
		[RED("animationState")] 
		public CEnum<EComputerAnimationState> AnimationState
		{
			get => GetProperty(ref _animationState);
			set => SetProperty(ref _animationState, value);
		}
	}
}
