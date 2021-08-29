using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ComputerMenuButtonController : DeviceButtonLogicControllerBase
	{
		private inkTextWidgetReference _counterWidget;
		private inkWidgetReference _notificationidget;
		private CString _menuID;

		[Ordinal(26)] 
		[RED("counterWidget")] 
		public inkTextWidgetReference CounterWidget
		{
			get => GetProperty(ref _counterWidget);
			set => SetProperty(ref _counterWidget, value);
		}

		[Ordinal(27)] 
		[RED("notificationidget")] 
		public inkWidgetReference Notificationidget
		{
			get => GetProperty(ref _notificationidget);
			set => SetProperty(ref _notificationidget, value);
		}

		[Ordinal(28)] 
		[RED("menuID")] 
		public CString MenuID
		{
			get => GetProperty(ref _menuID);
			set => SetProperty(ref _menuID, value);
		}
	}
}
