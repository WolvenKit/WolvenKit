using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDeviceWidgetPackage : SWidgetPackage
	{
		private CString _deviceStatus;
		private CEnum<EDeviceStatus> _deviceState;
		private CArray<SActionWidgetPackage> _actionWidgets;

		[Ordinal(17)] 
		[RED("deviceStatus")] 
		public CString DeviceStatus
		{
			get => GetProperty(ref _deviceStatus);
			set => SetProperty(ref _deviceStatus, value);
		}

		[Ordinal(18)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get => GetProperty(ref _deviceState);
			set => SetProperty(ref _deviceState, value);
		}

		[Ordinal(19)] 
		[RED("actionWidgets")] 
		public CArray<SActionWidgetPackage> ActionWidgets
		{
			get => GetProperty(ref _actionWidgets);
			set => SetProperty(ref _actionWidgets, value);
		}

		public SDeviceWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
