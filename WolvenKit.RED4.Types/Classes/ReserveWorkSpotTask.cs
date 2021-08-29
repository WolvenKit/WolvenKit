using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReserveWorkSpotTask : WorkSpotTask
	{
		private NodeRef _workspotRef;
		private CWeakHandle<gameObject> _workspotObject;

		[Ordinal(0)] 
		[RED("workspotRef")] 
		public NodeRef WorkspotRef
		{
			get => GetProperty(ref _workspotRef);
			set => SetProperty(ref _workspotRef, value);
		}

		[Ordinal(1)] 
		[RED("workspotObject")] 
		public CWeakHandle<gameObject> WorkspotObject
		{
			get => GetProperty(ref _workspotObject);
			set => SetProperty(ref _workspotObject, value);
		}
	}
}
