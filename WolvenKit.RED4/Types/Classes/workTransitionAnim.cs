using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workTransitionAnim : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("idleA")] 
		public CName IdleA
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("idleB")] 
		public CName IdleB
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("transitionAtoB")] 
		public CName TransitionAtoB
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("transitionBtoA")] 
		public CName TransitionBtoA
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public workTransitionAnim()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
