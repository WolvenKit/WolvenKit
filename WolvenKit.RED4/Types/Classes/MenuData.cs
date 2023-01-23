using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MenuData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("identifier")] 
		public CInt32 Identifier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("label")] 
		public CString Label
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CName Icon
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("subMenus")] 
		public CArray<MenuData> SubMenus
		{
			get => GetPropertyValue<CArray<MenuData>>();
			set => SetPropertyValue<CArray<MenuData>>(value);
		}

		[Ordinal(4)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("fullscreenName")] 
		public CName FullscreenName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		[Ordinal(7)] 
		[RED("disabled")] 
		public CBool Disabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("parentIdentifier")] 
		public CInt32 ParentIdentifier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("attrFlag")] 
		public CBool AttrFlag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("attrText")] 
		public CInt32 AttrText
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("perkFlag")] 
		public CBool PerkFlag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("perkText")] 
		public CInt32 PerkText
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("overrideDefaultUserData")] 
		public CBool OverrideDefaultUserData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("overrideSubMenuUserData")] 
		public CBool OverrideSubMenuUserData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MenuData()
		{
			Identifier = -1;
			SubMenus = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
