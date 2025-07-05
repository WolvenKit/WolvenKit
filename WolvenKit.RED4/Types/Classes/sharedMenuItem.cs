using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sharedMenuItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CName Id
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("tooltip")] 
		public CString Tooltip
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("subItems")] 
		public CArray<sharedMenuItem> SubItems
		{
			get => GetPropertyValue<CArray<sharedMenuItem>>();
			set => SetPropertyValue<CArray<sharedMenuItem>>(value);
		}

		[Ordinal(4)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<sharedMenuItemType> Type
		{
			get => GetPropertyValue<CEnum<sharedMenuItemType>>();
			set => SetPropertyValue<CEnum<sharedMenuItemType>>(value);
		}

		[Ordinal(6)] 
		[RED("isChecked")] 
		public CBool IsChecked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("checkGroup")] 
		public CString CheckGroup
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public sharedMenuItem()
		{
			SubItems = new();
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
