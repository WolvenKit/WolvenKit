using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhysicalHackingEvent : redEvent
	{
		private CString _deviceName;

		[Ordinal(0)] 
		[RED("deviceName")] 
		public CString DeviceName
		{
			get => GetProperty(ref _deviceName);
			set => SetProperty(ref _deviceName, value);
		}
	}
}
