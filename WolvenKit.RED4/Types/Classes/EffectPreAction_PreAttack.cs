using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EffectPreAction_PreAttack : gameEffectPreAction_Scripted
	{
		[Ordinal(0)] 
		[RED("withFriendlyFire")] 
		public CBool WithFriendlyFire
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("withSelfDamage")] 
		public CBool WithSelfDamage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EffectPreAction_PreAttack()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
