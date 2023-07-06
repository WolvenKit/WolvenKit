using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ComputerMenuButtonController : DeviceButtonLogicControllerBase
	{
		[Ordinal(26)] 
		[RED("counterWidget")] 
		public inkTextWidgetReference CounterWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("notificationidget")] 
		public inkWidgetReference Notificationidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("menuID")] 
		public CString MenuID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ComputerMenuButtonController()
		{
			CounterWidget = new inkTextWidgetReference();
			Notificationidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
