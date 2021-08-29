using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OpenMenuRequest : redEvent
	{
		private CName _menuName;
		private CHandle<IScriptable> _userData;
		private CBool _jumpBack;
		private MenuData _eventData;
		private CName _submenuName;
		private CBool _isMainMenu;
		private CUInt32 _hubMenuInstanceID;

		[Ordinal(0)] 
		[RED("menuName")] 
		public CName MenuName
		{
			get => GetProperty(ref _menuName);
			set => SetProperty(ref _menuName, value);
		}

		[Ordinal(1)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		[Ordinal(2)] 
		[RED("jumpBack")] 
		public CBool JumpBack
		{
			get => GetProperty(ref _jumpBack);
			set => SetProperty(ref _jumpBack, value);
		}

		[Ordinal(3)] 
		[RED("eventData")] 
		public MenuData EventData
		{
			get => GetProperty(ref _eventData);
			set => SetProperty(ref _eventData, value);
		}

		[Ordinal(4)] 
		[RED("submenuName")] 
		public CName SubmenuName
		{
			get => GetProperty(ref _submenuName);
			set => SetProperty(ref _submenuName, value);
		}

		[Ordinal(5)] 
		[RED("isMainMenu")] 
		public CBool IsMainMenu
		{
			get => GetProperty(ref _isMainMenu);
			set => SetProperty(ref _isMainMenu, value);
		}

		[Ordinal(6)] 
		[RED("hubMenuInstanceID")] 
		public CUInt32 HubMenuInstanceID
		{
			get => GetProperty(ref _hubMenuInstanceID);
			set => SetProperty(ref _hubMenuInstanceID, value);
		}
	}
}
