using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorMountRequestConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("testMountRequest")] 
		public CBool TestMountRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("testUnmountRequest")] 
		public CBool TestUnmountRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("acceptInstant")] 
		public CBool AcceptInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("acceptNotInstant")] 
		public CBool AcceptNotInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorMountRequestConditionDefinition()
		{
			TestMountRequest = true;
			AcceptInstant = true;
			AcceptNotInstant = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
