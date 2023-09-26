using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBreachControllerComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("canHaveBreaches")] 
		public CBool CanHaveBreaches
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("allowNormalBreachesAfterWeakspotsAreDestroyed")] 
		public CBool AllowNormalBreachesAfterWeakspotsAreDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("debugAllowBreachesAfterDestruction")] 
		public CBool DebugAllowBreachesAfterDestruction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("breachesScale")] 
		public CFloat BreachesScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameBreachControllerComponent()
		{
			Name = "Component";
			CanHaveBreaches = true;
			BreachesScale = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
