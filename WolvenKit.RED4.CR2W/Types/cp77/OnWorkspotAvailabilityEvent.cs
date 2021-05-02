using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnWorkspotAvailabilityEvent : redEvent
	{
		private NodeRef _workspotRef;

		[Ordinal(0)] 
		[RED("workspotRef")] 
		public NodeRef WorkspotRef
		{
			get => GetProperty(ref _workspotRef);
			set => SetProperty(ref _workspotRef, value);
		}

		public OnWorkspotAvailabilityEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
