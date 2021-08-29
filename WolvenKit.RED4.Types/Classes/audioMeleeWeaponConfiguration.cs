using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeWeaponConfiguration : audioAudioMetadata
	{
		private audioMeleeSound _fastWhoosh;
		private audioMeleeSound _normalWhoosh;
		private audioMeleeSound _slowWhoosh;
		private audioMeleeSound _detailSound;
		private audioMeleeSound _handlingSound;
		private audioMeleeSound _equipSound;
		private audioMeleeSound _unequipSound;
		private audioMeleeSound _blockSound;
		private audioMeleeSound _parrySound;
		private CHandle<audioMeleeHitTypeMeleeSoundDictionary> _meleeSoundsByHitPerMaterialType;
		private audioMeleeRigTypeMeleeWeaponConfigurationMap _meleeWeaponConfigurationsByRigTypeMap;

		[Ordinal(1)] 
		[RED("fastWhoosh")] 
		public audioMeleeSound FastWhoosh
		{
			get => GetProperty(ref _fastWhoosh);
			set => SetProperty(ref _fastWhoosh, value);
		}

		[Ordinal(2)] 
		[RED("normalWhoosh")] 
		public audioMeleeSound NormalWhoosh
		{
			get => GetProperty(ref _normalWhoosh);
			set => SetProperty(ref _normalWhoosh, value);
		}

		[Ordinal(3)] 
		[RED("slowWhoosh")] 
		public audioMeleeSound SlowWhoosh
		{
			get => GetProperty(ref _slowWhoosh);
			set => SetProperty(ref _slowWhoosh, value);
		}

		[Ordinal(4)] 
		[RED("detailSound")] 
		public audioMeleeSound DetailSound
		{
			get => GetProperty(ref _detailSound);
			set => SetProperty(ref _detailSound, value);
		}

		[Ordinal(5)] 
		[RED("handlingSound")] 
		public audioMeleeSound HandlingSound
		{
			get => GetProperty(ref _handlingSound);
			set => SetProperty(ref _handlingSound, value);
		}

		[Ordinal(6)] 
		[RED("equipSound")] 
		public audioMeleeSound EquipSound
		{
			get => GetProperty(ref _equipSound);
			set => SetProperty(ref _equipSound, value);
		}

		[Ordinal(7)] 
		[RED("unequipSound")] 
		public audioMeleeSound UnequipSound
		{
			get => GetProperty(ref _unequipSound);
			set => SetProperty(ref _unequipSound, value);
		}

		[Ordinal(8)] 
		[RED("blockSound")] 
		public audioMeleeSound BlockSound
		{
			get => GetProperty(ref _blockSound);
			set => SetProperty(ref _blockSound, value);
		}

		[Ordinal(9)] 
		[RED("parrySound")] 
		public audioMeleeSound ParrySound
		{
			get => GetProperty(ref _parrySound);
			set => SetProperty(ref _parrySound, value);
		}

		[Ordinal(10)] 
		[RED("meleeSoundsByHitPerMaterialType")] 
		public CHandle<audioMeleeHitTypeMeleeSoundDictionary> MeleeSoundsByHitPerMaterialType
		{
			get => GetProperty(ref _meleeSoundsByHitPerMaterialType);
			set => SetProperty(ref _meleeSoundsByHitPerMaterialType, value);
		}

		[Ordinal(11)] 
		[RED("meleeWeaponConfigurationsByRigTypeMap")] 
		public audioMeleeRigTypeMeleeWeaponConfigurationMap MeleeWeaponConfigurationsByRigTypeMap
		{
			get => GetProperty(ref _meleeWeaponConfigurationsByRigTypeMap);
			set => SetProperty(ref _meleeWeaponConfigurationsByRigTypeMap, value);
		}
	}
}
