using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIFollowerTakedownCommand : AIFollowerCommand
	{
		[Ordinal(5)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(6)] 
		[RED("approachBeforeTakedown")] 
		public CBool ApproachBeforeTakedown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("doNotTeleportIfTargetIsVisible")] 
		public CBool DoNotTeleportIfTargetIsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public AIFollowerTakedownCommand()
		{
			TargetRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
