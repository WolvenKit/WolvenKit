using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OpenMenuRequest : redEvent
	{
		[Ordinal(0)] 
		[RED("menuName")] 
		public CName MenuName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		[Ordinal(2)] 
		[RED("jumpBack")] 
		public CBool JumpBack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("eventData")] 
		public MenuData EventData
		{
			get => GetPropertyValue<MenuData>();
			set => SetPropertyValue<MenuData>(value);
		}

		[Ordinal(4)] 
		[RED("submenuName")] 
		public CName SubmenuName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("isMainMenu")] 
		public CBool IsMainMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("internal")] 
		public CBool Internal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("hubMenuInstanceID")] 
		public CUInt32 HubMenuInstanceID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public OpenMenuRequest()
		{
			EventData = new() { Identifier = -1, SubMenus = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
