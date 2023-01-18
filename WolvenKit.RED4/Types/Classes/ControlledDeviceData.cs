using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ControlledDeviceData : WidgetCustomData
	{
		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ControlledDeviceData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
