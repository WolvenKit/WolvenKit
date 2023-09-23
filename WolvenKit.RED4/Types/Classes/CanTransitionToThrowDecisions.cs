using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CanTransitionToThrowDecisions : CarriedObjectDecisions
	{
		[Ordinal(0)] 
		[RED("throwNPCActionReleasedName")] 
		public CName ThrowNPCActionReleasedName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("throwNPCActionReleasedTime")] 
		public CFloat ThrowNPCActionReleasedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("canThrow")] 
		public CBool CanThrow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("canThrowInitialized")] 
		public CBool CanThrowInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CanTransitionToThrowDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
