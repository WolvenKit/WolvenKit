using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveToNodeRefEvent : redEvent
	{
		private NodeRef _targetRef;
		private CBool _useTraffic;
		private CFloat _speedInTraffic;

		[Ordinal(0)] 
		[RED("targetRef")] 
		public NodeRef TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		[Ordinal(1)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get => GetProperty(ref _useTraffic);
			set => SetProperty(ref _useTraffic, value);
		}

		[Ordinal(2)] 
		[RED("speedInTraffic")] 
		public CFloat SpeedInTraffic
		{
			get => GetProperty(ref _speedInTraffic);
			set => SetProperty(ref _speedInTraffic, value);
		}

		public vehicleDriveToNodeRefEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
