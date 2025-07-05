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

		[Ordinal(2)] 
		[RED("includePierced")] 
		public CBool IncludePierced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectObjectFilter_OnlyNearest_Pierce()
		{
			IncludePierced = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
