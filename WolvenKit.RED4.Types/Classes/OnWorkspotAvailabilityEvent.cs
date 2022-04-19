using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnWorkspotAvailabilityEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("workspotRef")] 
		public NodeRef WorkspotRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public OnWorkspotAvailabilityEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
