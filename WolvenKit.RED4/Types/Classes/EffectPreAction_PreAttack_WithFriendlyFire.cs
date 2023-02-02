
namespace WolvenKit.RED4.Types
{
	public partial class EffectPreAction_PreAttack_WithFriendlyFire : EffectPreAction_PreAttack
	{
		public EffectPreAction_PreAttack_WithFriendlyFire()
		{
			WithFriendlyFire = true;
			WithSelfDamage = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
