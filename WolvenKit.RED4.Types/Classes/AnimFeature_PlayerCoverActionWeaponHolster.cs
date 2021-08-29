using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_PlayerCoverActionWeaponHolster : animAnimFeature
	{
		private CBool _isWeaponHolstered;

		[Ordinal(0)] 
		[RED("isWeaponHolstered")] 
		public CBool IsWeaponHolstered
		{
			get => GetProperty(ref _isWeaponHolstered);
			set => SetProperty(ref _isWeaponHolstered, value);
		}
	}
}
