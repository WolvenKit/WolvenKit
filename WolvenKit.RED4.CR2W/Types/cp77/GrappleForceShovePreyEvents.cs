using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrappleForceShovePreyEvents : LocomotionTakedownEvents
	{
		private CBool _unmountCalled;

		[Ordinal(1)] 
		[RED("unmountCalled")] 
		public CBool UnmountCalled
		{
			get => GetProperty(ref _unmountCalled);
			set => SetProperty(ref _unmountCalled, value);
		}

		public GrappleForceShovePreyEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
