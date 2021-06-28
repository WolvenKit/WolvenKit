using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NotifyHighlightedDevice : redEvent
	{
		private CBool _isDeviceHighlighted;
		private CBool _isNotifiedByMasterDevice;

		[Ordinal(0)] 
		[RED("IsDeviceHighlighted")] 
		public CBool IsDeviceHighlighted
		{
			get => GetProperty(ref _isDeviceHighlighted);
			set => SetProperty(ref _isDeviceHighlighted, value);
		}

		[Ordinal(1)] 
		[RED("IsNotifiedByMasterDevice")] 
		public CBool IsNotifiedByMasterDevice
		{
			get => GetProperty(ref _isNotifiedByMasterDevice);
			set => SetProperty(ref _isNotifiedByMasterDevice, value);
		}

		public NotifyHighlightedDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
