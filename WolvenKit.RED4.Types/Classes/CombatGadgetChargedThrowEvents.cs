using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CombatGadgetChargedThrowEvents : CombatGadgetTransitions
	{
		[Ordinal(0)] 
		[RED("grenadeThrown")] 
		public CBool GrenadeThrown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("localAimForward")] 
		public Vector4 LocalAimForward
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("localAimPosition")] 
		public Vector4 LocalAimPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public CombatGadgetChargedThrowEvents()
		{
			LocalAimForward = new();
			LocalAimPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
