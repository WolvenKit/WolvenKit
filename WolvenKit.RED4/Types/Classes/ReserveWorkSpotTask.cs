using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReserveWorkSpotTask : WorkSpotTask
	{
		[Ordinal(0)] 
		[RED("workspotRef")] 
		public NodeRef WorkspotRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("workspotObject")] 
		public CWeakHandle<gameObject> WorkspotObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public ReserveWorkSpotTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
