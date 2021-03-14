using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerSetup : TerminalSetup
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
			get
			{
				if (_startingMenu == null)
				{
					_startingMenu = (CEnum<EComputerMenuType>) CR2WTypeManager.Create("EComputerMenuType", "startingMenu", cr2w, this);
				}
				return _startingMenu;
			}
			set
			{
				if (_startingMenu == value)
				{
					return;
				}
				_startingMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("mailsMenu")] 
		public CBool MailsMenu
		{
			get
			{
				if (_mailsMenu == null)
				{
					_mailsMenu = (CBool) CR2WTypeManager.Create("Bool", "mailsMenu", cr2w, this);
				}
				return _mailsMenu;
			}
			set
			{
				if (_mailsMenu == value)
				{
					return;
				}
				_mailsMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("filesMenu")] 
		public CBool FilesMenu
		{
			get
			{
				if (_filesMenu == null)
				{
					_filesMenu = (CBool) CR2WTypeManager.Create("Bool", "filesMenu", cr2w, this);
				}
				return _filesMenu;
			}
			set
			{
				if (_filesMenu == value)
				{
					return;
				}
				_filesMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("systemMenu")] 
		public CBool SystemMenu
		{
			get
			{
				if (_systemMenu == null)
				{
					_systemMenu = (CBool) CR2WTypeManager.Create("Bool", "systemMenu", cr2w, this);
				}
				return _systemMenu;
			}
			set
			{
				if (_systemMenu == value)
				{
					return;
				}
				_systemMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("internetMenu")] 
		public CBool InternetMenu
		{
			get
			{
				if (_internetMenu == null)
				{
					_internetMenu = (CBool) CR2WTypeManager.Create("Bool", "internetMenu", cr2w, this);
				}
				return _internetMenu;
			}
			set
			{
				if (_internetMenu == value)
				{
					return;
				}
				_internetMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("newsFeedMenu")] 
		public CBool NewsFeedMenu
		{
			get
			{
				if (_newsFeedMenu == null)
				{
					_newsFeedMenu = (CBool) CR2WTypeManager.Create("Bool", "newsFeedMenu", cr2w, this);
				}
				return _newsFeedMenu;
			}
			set
			{
				if (_newsFeedMenu == value)
				{
					return;
				}
				_newsFeedMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("mailsStructure")] 
		public CArray<gamedeviceGenericDataContent> MailsStructure
		{
			get
			{
				if (_mailsStructure == null)
				{
					_mailsStructure = (CArray<gamedeviceGenericDataContent>) CR2WTypeManager.Create("array:gamedeviceGenericDataContent", "mailsStructure", cr2w, this);
				}
				return _mailsStructure;
			}
			set
			{
				if (_mailsStructure == value)
				{
					return;
				}
				_mailsStructure = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("filesStructure")] 
		public CArray<gamedeviceGenericDataContent> FilesStructure
		{
			get
			{
				if (_filesStructure == null)
				{
					_filesStructure = (CArray<gamedeviceGenericDataContent>) CR2WTypeManager.Create("array:gamedeviceGenericDataContent", "filesStructure", cr2w, this);
				}
				return _filesStructure;
			}
			set
			{
				if (_filesStructure == value)
				{
					return;
				}
				_filesStructure = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("newsFeed")] 
		public CArray<SNewsFeedElementData> NewsFeed
		{
			get
			{
				if (_newsFeed == null)
				{
					_newsFeed = (CArray<SNewsFeedElementData>) CR2WTypeManager.Create("array:SNewsFeedElementData", "newsFeed", cr2w, this);
				}
				return _newsFeed;
			}
			set
			{
				if (_newsFeed == value)
				{
					return;
				}
				_newsFeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("newsFeedInterval")] 
		public CFloat NewsFeedInterval
		{
			get
			{
				if (_newsFeedInterval == null)
				{
					_newsFeedInterval = (CFloat) CR2WTypeManager.Create("Float", "newsFeedInterval", cr2w, this);
				}
				return _newsFeedInterval;
			}
			set
			{
				if (_newsFeedInterval == value)
				{
					return;
				}
				_newsFeedInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("internetSubnet")] 
		public SInternetData InternetSubnet
		{
			get
			{
				if (_internetSubnet == null)
				{
					_internetSubnet = (SInternetData) CR2WTypeManager.Create("SInternetData", "internetSubnet", cr2w, this);
				}
				return _internetSubnet;
			}
			set
			{
				if (_internetSubnet == value)
				{
					return;
				}
				_internetSubnet = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("animationState")] 
		public CEnum<EComputerAnimationState> AnimationState
		{
			get
			{
				if (_animationState == null)
				{
					_animationState = (CEnum<EComputerAnimationState>) CR2WTypeManager.Create("EComputerAnimationState", "animationState", cr2w, this);
				}
				return _animationState;
			}
			set
			{
				if (_animationState == value)
				{
					return;
				}
				_animationState = value;
				PropertySet(this);
			}
		}

		public ComputerSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
