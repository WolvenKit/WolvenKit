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
		[RED("attackChargedThreshold")] 
		public CFloat AttackChargedThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("attackChargedSound")] 
		public audioMeleeSound AttackChargedSound
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(12)] 
		[RED("attackDischargedSound")] 
		public audioMeleeSound AttackDischargedSound
		{
			get => GetPropertyValue<audioMeleeSound>();
			set => SetPropertyValue<audioMeleeSound>(value);
		}

		[Ordinal(13)] 
		[RED("meleeSoundsByHitPerMaterialType")] 
		public CHandle<audioMeleeHitTypeMeleeSoundDictionary> MeleeSoundsByHitPerMaterialType
		{
			get => GetPropertyValue<CHandle<audioMeleeHitTypeMeleeSoundDictionary>>();
			set => SetPropertyValue<CHandle<audioMeleeHitTypeMeleeSoundDictionary>>(value);
		}

		[Ordinal(14)] 
		[RED("meleeWeaponConfigurationsByRigTypeMap")] 
		public audioMeleeRigTypeMeleeWeaponConfigurationMap MeleeWeaponConfigurationsByRigTypeMap
		{
			get => GetPropertyValue<audioMeleeRigTypeMeleeWeaponConfigurationMap>();
			set => SetPropertyValue<audioMeleeRigTypeMeleeWeaponConfigurationMap>(value);
		}

		public audioMeleeWeaponConfiguration()
		{
			FastWhoosh = new audioMeleeSound { Events = new() };
			NormalWhoosh = new audioMeleeSound { Events = new() };
			SlowWhoosh = new audioMeleeSound { Events = new() };
			DetailSound = new audioMeleeSound { Events = new() };
			HandlingSound = new audioMeleeSound { Events = new() };
			EquipSound = new audioMeleeSound { Events = new() };
			UnequipSound = new audioMeleeSound { Events = new() };
			BlockSound = new audioMeleeSound { Events = new() };
			ParrySound = new audioMeleeSound { Events = new() };
			AttackChargedThreshold = 90.000000F;
			AttackChargedSound = new audioMeleeSound { Events = new() };
			AttackDischargedSound = new audioMeleeSound { Events = new() };
			MeleeWeaponConfigurationsByRigTypeMap = new audioMeleeRigTypeMeleeWeaponConfigurationMap { MapItems = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
