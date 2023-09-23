using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MountRequestCondition : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("testMountRequest")] 
		public CBool TestMountRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("testUnmountRequest")] 
		public CBool TestUnmountRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("acceptInstant")] 
		public CBool AcceptInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("acceptNotInstant")] 
		public CBool AcceptNotInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MountRequestCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
