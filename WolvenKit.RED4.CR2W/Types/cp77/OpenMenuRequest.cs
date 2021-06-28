using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpenMenuRequest : redEvent
	{
		private CName _menuName;
		private CHandle<IScriptable> _userData;
		private CBool _jumpBack;
		private MenuData _eventData;
		private CName _submenuName;
		private CBool _isMainMenu;

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

		public OpenMenuRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
