using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSlotWeaponData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("weaponID")] 
		public gameItemID WeaponID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("ammoCurrent")] 
		public CInt32 AmmoCurrent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("magazineCap")] 
		public CInt32 MagazineCap
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("ammoId")] 
		public gameItemID AmmoId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(4)] 
		[RED("triggerModeCurrent")] 
		public CEnum<gamedataTriggerMode> TriggerModeCurrent
		{
			get => GetPropertyValue<CEnum<gamedataTriggerMode>>();
			set => SetPropertyValue<CEnum<gamedataTriggerMode>>(value);
		}

		[Ordinal(5)] 
		[RED("triggerModeList")] 
		public CArray<CEnum<gamedataTriggerMode>> TriggerModeList
		{
			get => GetPropertyValue<CArray<CEnum<gamedataTriggerMode>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataTriggerMode>>>(value);
		}

		[Ordinal(6)] 
		[RED("evolution")] 
		public CEnum<gamedataWeaponEvolution> Evolution
		{
			get => GetPropertyValue<CEnum<gamedataWeaponEvolution>>();
			set => SetPropertyValue<CEnum<gamedataWeaponEvolution>>(value);
		}

		[Ordinal(7)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("isFirstEquip")] 
		public CBool IsFirstEquip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameSlotWeaponData()
		{
			WeaponID = new();
			AmmoCurrent = -1;
			MagazineCap = -1;
			AmmoId = new();
			TriggerModeCurrent = Enums.gamedataTriggerMode.Invalid;
			TriggerModeList = new();
			Evolution = Enums.gamedataWeaponEvolution.Invalid;
			IsFirstEquip = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
