using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class KeypadButtonSpawnData : IScriptable
	{
		[Ordinal(0)] 
		[RED("widgetName")] 
		public CName WidgetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("locKey")] 
		public CString LocKey
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("isActionButton")] 
		public CBool IsActionButton
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("widgetData")] 
		public SDeviceWidgetPackage WidgetData
		{
			get => GetPropertyValue<SDeviceWidgetPackage>();
			set => SetPropertyValue<SDeviceWidgetPackage>(value);
		}

		public KeypadButtonSpawnData()
		{
			WidgetData = new() { ActionWidgets = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
