using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_OnlyNearest_Pierce : gameEffectObjectFilter_OnlyNearest
	{
		[Ordinal(1)] 
		[RED("alwaysApplyFullWeaponCharge")] 
		public CBool AlwaysApplyFullWeaponCharge
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
