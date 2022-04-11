using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeWeaponConfiguration : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("fastWhoosh")] 
		public audioMeleeSound FastWhoosh
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(2)] 
		[RED("normalWhoosh")] 
		public audioMeleeSound NormalWhoosh
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(3)] 
		[RED("slowWhoosh")] 
		public audioMeleeSound SlowWhoosh
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(4)] 
		[RED("detailSound")] 
		public audioMeleeSound DetailSound
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(5)] 
		[RED("handlingSound")] 
		public audioMeleeSound HandlingSound
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(6)] 
		[RED("equipSound")] 
		public audioMeleeSound EquipSound
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(7)] 
		[RED("unequipSound")] 
		public audioMeleeSound UnequipSound
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(8)] 
		[RED("blockSound")] 
		public audioMeleeSound BlockSound
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(9)] 
		[RED("parrySound")] 
		public audioMeleeSound ParrySound
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(10)] 
		[RED("meleeSoundsByHitPerMaterialType")] 
		public CHandle<audioMeleeHitTypeMeleeSoundDictionary> MeleeSoundsByHitPerMaterialType
		{
			get => GetPropertyValue<CHandle<audioMeleeHitTypeMeleeSoundDictionary>>();
			set => SetPropertyValue<CHandle<audioMeleeHitTypeMeleeSoundDictionary>>(value);
		}

		[Ordinal(11)] 
		[RED("meleeWeaponConfigurationsByRigTypeMap")] 
		public audioMeleeRigTypeMeleeWeaponConfigurationMap MeleeWeaponConfigurationsByRigTypeMap
		{
			get => GetPropertyValue<audioMeleeRigTypeMeleeWeaponConfigurationMap>();
			set => SetPropertyValue<audioMeleeRigTypeMeleeWeaponConfigurationMap>(value);
		}

		public audioMeleeWeaponConfiguration()
		{
			FastWhoosh = new() { Events = new() };
			NormalWhoosh = new() { Events = new() };
			SlowWhoosh = new() { Events = new() };
			DetailSound = new() { Events = new() };
			HandlingSound = new() { Events = new() };
			EquipSound = new() { Events = new() };
			UnequipSound = new() { Events = new() };
			BlockSound = new() { Events = new() };
			ParrySound = new() { Events = new() };
			MeleeWeaponConfigurationsByRigTypeMap = new() { MapItems = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
