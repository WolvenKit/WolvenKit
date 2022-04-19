using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_OnlyNearest_Pierce : gameEffectObjectFilter_OnlyNearest
	{
		[Ordinal(1)] 
		[RED("alwaysApplyFullWeaponCharge")] 
		public CBool AlwaysApplyFullWeaponCharge
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectObjectFilter_OnlyNearest_Pierce()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
