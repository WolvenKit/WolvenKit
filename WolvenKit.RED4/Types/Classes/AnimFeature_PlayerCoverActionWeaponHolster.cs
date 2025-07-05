using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_PlayerCoverActionWeaponHolster : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isWeaponHolstered")] 
		public CBool IsWeaponHolstered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_PlayerCoverActionWeaponHolster()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
