using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhysicalHackingEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("deviceName")] 
		public CString DeviceName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public PhysicalHackingEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
