using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReserveWorkSpotTask : WorkSpotTask
	{
		private NodeRef _workspotRef;
		private wCHandle<gameObject> _workspotObject;

		[Ordinal(0)] 
		[RED("workspotRef")] 
		public NodeRef WorkspotRef
		{
			get => GetProperty(ref _workspotRef);
			set => SetProperty(ref _workspotRef, value);
		}

		[Ordinal(1)] 
		[RED("workspotObject")] 
		public wCHandle<gameObject> WorkspotObject
		{
			get => GetProperty(ref _workspotObject);
			set => SetProperty(ref _workspotObject, value);
		}

		public ReserveWorkSpotTask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
