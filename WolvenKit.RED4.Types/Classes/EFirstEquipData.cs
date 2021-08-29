using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EFirstEquipData : RedBaseClass
	{
		private TweakDBID _weaponID;
		private CBool _hasPlayedFirstEquip;

		[Ordinal(0)] 
		[RED("weaponID")] 
		public TweakDBID WeaponID
		{
			get => GetProperty(ref _weaponID);
			set => SetProperty(ref _weaponID, value);
		}

		[Ordinal(1)] 
		[RED("hasPlayedFirstEquip")] 
		public CBool HasPlayedFirstEquip
		{
			get => GetProperty(ref _hasPlayedFirstEquip);
			set => SetProperty(ref _hasPlayedFirstEquip, value);
		}
	}
}
