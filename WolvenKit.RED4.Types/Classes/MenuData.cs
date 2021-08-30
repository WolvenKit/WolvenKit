using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuData : RedBaseClass
	{
		private CInt32 _identifier;
		private CString _label;
		private CName _icon;
		private CArray<MenuData> _subMenus;
		private CName _eventName;
		private CName _fullscreenName;
		private CHandle<IScriptable> _userData;
		private CBool _disabled;
		private CInt32 _parentIdentifier;
		private CBool _attrFlag;
		private CInt32 _attrText;
		private CBool _perkFlag;
		private CInt32 _perkText;
		private CBool _overrideDefaultUserData;
		private CBool _overrideSubMenuUserData;

		[Ordinal(0)] 
		[RED("identifier")] 
		public CInt32 Identifier
		{
			get => GetProperty(ref _identifier);
			set => SetProperty(ref _identifier, value);
		}

		[Ordinal(1)] 
		[RED("label")] 
		public CString Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CName Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(3)] 
		[RED("subMenus")] 
		public CArray<MenuData> SubMenus
		{
			get => GetProperty(ref _subMenus);
			set => SetProperty(ref _subMenus, value);
		}

		[Ordinal(4)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(5)] 
		[RED("fullscreenName")] 
		public CName FullscreenName
		{
			get => GetProperty(ref _fullscreenName);
			set => SetProperty(ref _fullscreenName, value);
		}

		[Ordinal(6)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		[Ordinal(7)] 
		[RED("disabled")] 
		public CBool Disabled
		{
			get => GetProperty(ref _disabled);
			set => SetProperty(ref _disabled, value);
		}

		[Ordinal(8)] 
		[RED("parentIdentifier")] 
		public CInt32 ParentIdentifier
		{
			get => GetProperty(ref _parentIdentifier);
			set => SetProperty(ref _parentIdentifier, value);
		}

		[Ordinal(9)] 
		[RED("attrFlag")] 
		public CBool AttrFlag
		{
			get => GetProperty(ref _attrFlag);
			set => SetProperty(ref _attrFlag, value);
		}

		[Ordinal(10)] 
		[RED("attrText")] 
		public CInt32 AttrText
		{
			get => GetProperty(ref _attrText);
			set => SetProperty(ref _attrText, value);
		}

		[Ordinal(11)] 
		[RED("perkFlag")] 
		public CBool PerkFlag
		{
			get => GetProperty(ref _perkFlag);
			set => SetProperty(ref _perkFlag, value);
		}

		[Ordinal(12)] 
		[RED("perkText")] 
		public CInt32 PerkText
		{
			get => GetProperty(ref _perkText);
			set => SetProperty(ref _perkText, value);
		}

		[Ordinal(13)] 
		[RED("overrideDefaultUserData")] 
		public CBool OverrideDefaultUserData
		{
			get => GetProperty(ref _overrideDefaultUserData);
			set => SetProperty(ref _overrideDefaultUserData, value);
		}

		[Ordinal(14)] 
		[RED("overrideSubMenuUserData")] 
		public CBool OverrideSubMenuUserData
		{
			get => GetProperty(ref _overrideSubMenuUserData);
			set => SetProperty(ref _overrideSubMenuUserData, value);
		}

		public MenuData()
		{
			_identifier = -1;
		}
	}
}
