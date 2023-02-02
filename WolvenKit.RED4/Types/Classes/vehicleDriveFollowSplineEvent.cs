using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleDriveFollowSplineEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("backwards")] 
		public CBool Backwards
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleDriveFollowSplineEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
