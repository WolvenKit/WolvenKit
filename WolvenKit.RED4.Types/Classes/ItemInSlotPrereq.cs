using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemInSlotPrereq : gameIScriptablePrereq
	{
		private TweakDBID _slotID;
		private CEnum<EItemSlotCheckType> _slotCheckType;
		private CEnum<gamedataItemType> _itemType;
		private CEnum<gamedataItemCategory> _itemCategory;
		private CEnum<gamedataWeaponEvolution> _weaponEvolution;
		private CName _itemTag;
		private CBool _invert;
		private CBool _skipOnApply;

		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("slotCheckType")] 
		public CEnum<EItemSlotCheckType> SlotCheckType
		{
			get => GetProperty(ref _slotCheckType);
			set => SetProperty(ref _slotCheckType, value);
		}

		[Ordinal(2)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(3)] 
		[RED("itemCategory")] 
		public CEnum<gamedataItemCategory> ItemCategory
		{
			get => GetProperty(ref _itemCategory);
			set => SetProperty(ref _itemCategory, value);
		}

		[Ordinal(4)] 
		[RED("weaponEvolution")] 
		public CEnum<gamedataWeaponEvolution> WeaponEvolution
		{
			get => GetProperty(ref _weaponEvolution);
			set => SetProperty(ref _weaponEvolution, value);
		}

		[Ordinal(5)] 
		[RED("itemTag")] 
		public CName ItemTag
		{
			get => GetProperty(ref _itemTag);
			set => SetProperty(ref _itemTag, value);
		}

		[Ordinal(6)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		[Ordinal(7)] 
		[RED("skipOnApply")] 
		public CBool SkipOnApply
		{
			get => GetProperty(ref _skipOnApply);
			set => SetProperty(ref _skipOnApply, value);
		}
	}
}
