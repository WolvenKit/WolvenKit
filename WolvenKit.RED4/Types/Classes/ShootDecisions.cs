using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShootDecisions : WeaponTransition
	{
		[Ordinal(3)] 
		[RED("stateBodyDone")] 
		public CBool StateBodyDone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ShootDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
