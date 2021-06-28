using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class drillMachineEvent : redEvent
	{
		private wCHandle<gameObject> _newTargetDevice;
		private CBool _newIsActive;

		[Ordinal(0)] 
		[RED("newTargetDevice")] 
		public wCHandle<gameObject> NewTargetDevice
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

		public drillMachineEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
