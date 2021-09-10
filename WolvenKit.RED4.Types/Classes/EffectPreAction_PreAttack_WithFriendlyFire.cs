
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectPreAction_PreAttack_WithFriendlyFire : EffectPreAction_PreAttack
	{

		public EffectPreAction_PreAttack_WithFriendlyFire()
		{
			WithFriendlyFire = true;
			WithSelfDamage = true;
		}
	}
}
