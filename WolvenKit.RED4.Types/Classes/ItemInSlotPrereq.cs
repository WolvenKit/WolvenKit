using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemInSlotPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("slotCheckType")] 
		public CEnum<EItemSlotCheckType> SlotCheckType
		{
			get => GetPropertyValue<CEnum<EItemSlotCheckType>>();
			set => SetPropertyValue<CEnum<EItemSlotCheckType>>(value);
		}

		[Ordinal(2)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(3)] 
		[RED("itemCategory")] 
		public CEnum<gamedataItemCategory> ItemCategory
		{
			get => GetPropertyValue<CEnum<gamedataItemCategory>>();
			set => SetPropertyValue<CEnum<gamedataItemCategory>>(value);
		}

		[Ordinal(4)] 
		[RED("weaponEvolution")] 
		public CEnum<gamedataWeaponEvolution> WeaponEvolution
		{
			get => GetPropertyValue<CEnum<gamedataWeaponEvolution>>();
			set => SetPropertyValue<CEnum<gamedataWeaponEvolution>>(value);
		}

		[Ordinal(5)] 
		[RED("itemTag")] 
		public CName ItemTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("skipOnApply")] 
		public CBool SkipOnApply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
