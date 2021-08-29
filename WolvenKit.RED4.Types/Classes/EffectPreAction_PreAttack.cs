using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectPreAction_PreAttack : gameEffectPreAction_Scripted
	{
		private CBool _withFriendlyFire;
		private CBool _withSelfDamage;

		[Ordinal(0)] 
		[RED("withFriendlyFire")] 
		public CBool WithFriendlyFire
		{
			get => GetProperty(ref _withFriendlyFire);
			set => SetProperty(ref _withFriendlyFire, value);
		}

		[Ordinal(1)] 
		[RED("withSelfDamage")] 
		public CBool WithSelfDamage
		{
			get => GetProperty(ref _withSelfDamage);
			set => SetProperty(ref _withSelfDamage, value);
		}
	}
}
