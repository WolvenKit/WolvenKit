using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class drillMachineEvent : redEvent
	{
		private CWeakHandle<gameObject> _newTargetDevice;
		private CBool _newIsActive;

		[Ordinal(0)] 
		[RED("newTargetDevice")] 
		public CWeakHandle<gameObject> NewTargetDevice
		{
			get => GetProperty(ref _newTargetDevice);
			set => SetProperty(ref _newTargetDevice, value);
		}

		[Ordinal(1)] 
		[RED("newIsActive")] 
		public CBool NewIsActive
		{
			get => GetProperty(ref _newIsActive);
			set => SetProperty(ref _newIsActive, value);
		}
	}
}
