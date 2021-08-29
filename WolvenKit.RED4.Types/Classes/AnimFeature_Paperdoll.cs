using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_Paperdoll : animAnimFeature
	{
		private CBool _genderSelection;
		private CBool _characterCreation;
		private CBool _characterCreation_Head;
		private CBool _characterCreation_Teeth;
		private CBool _characterCreation_Nails;
		private CBool _characterCreation_Summary;
		private CBool _inventoryScreen;
		private CBool _inventoryScreen_Weapon;
		private CBool _inventoryScreen_Legs;
		private CBool _inventoryScreen_Feet;
		private CBool _inventoryScreen_Cyberware;
		private CBool _inventoryScreen_QuickSlot;
		private CBool _inventoryScreen_Consumable;
		private CBool _inventoryScreen_Outfit;
		private CBool _inventoryScreen_Head;
		private CBool _inventoryScreen_Face;
		private CBool _inventoryScreen_InnerChest;
		private CBool _inventoryScreen_OuterChest;

		[Ordinal(0)] 
		[RED("genderSelection")] 
		public CBool GenderSelection
		{
			get => GetProperty(ref _genderSelection);
			set => SetProperty(ref _genderSelection, value);
		}

		[Ordinal(1)] 
		[RED("characterCreation")] 
		public CBool CharacterCreation
		{
			get => GetProperty(ref _characterCreation);
			set => SetProperty(ref _characterCreation, value);
		}

		[Ordinal(2)] 
		[RED("characterCreation_Head")] 
		public CBool CharacterCreation_Head
		{
			get => GetProperty(ref _characterCreation_Head);
			set => SetProperty(ref _characterCreation_Head, value);
		}

		[Ordinal(3)] 
		[RED("characterCreation_Teeth")] 
		public CBool CharacterCreation_Teeth
		{
			get => GetProperty(ref _characterCreation_Teeth);
			set => SetProperty(ref _characterCreation_Teeth, value);
		}

		[Ordinal(4)] 
		[RED("characterCreation_Nails")] 
		public CBool CharacterCreation_Nails
		{
			get => GetProperty(ref _characterCreation_Nails);
			set => SetProperty(ref _characterCreation_Nails, value);
		}

		[Ordinal(5)] 
		[RED("characterCreation_Summary")] 
		public CBool CharacterCreation_Summary
		{
			get => GetProperty(ref _characterCreation_Summary);
			set => SetProperty(ref _characterCreation_Summary, value);
		}

		[Ordinal(6)] 
		[RED("inventoryScreen")] 
		public CBool InventoryScreen
		{
			get => GetProperty(ref _inventoryScreen);
			set => SetProperty(ref _inventoryScreen, value);
		}

		[Ordinal(7)] 
		[RED("inventoryScreen_Weapon")] 
		public CBool InventoryScreen_Weapon
		{
			get => GetProperty(ref _inventoryScreen_Weapon);
			set => SetProperty(ref _inventoryScreen_Weapon, value);
		}

		[Ordinal(8)] 
		[RED("inventoryScreen_Legs")] 
		public CBool InventoryScreen_Legs
		{
			get => GetProperty(ref _inventoryScreen_Legs);
			set => SetProperty(ref _inventoryScreen_Legs, value);
		}

		[Ordinal(9)] 
		[RED("inventoryScreen_Feet")] 
		public CBool InventoryScreen_Feet
		{
			get => GetProperty(ref _inventoryScreen_Feet);
			set => SetProperty(ref _inventoryScreen_Feet, value);
		}

		[Ordinal(10)] 
		[RED("inventoryScreen_Cyberware")] 
		public CBool InventoryScreen_Cyberware
		{
			get => GetProperty(ref _inventoryScreen_Cyberware);
			set => SetProperty(ref _inventoryScreen_Cyberware, value);
		}

		[Ordinal(11)] 
		[RED("inventoryScreen_QuickSlot")] 
		public CBool InventoryScreen_QuickSlot
		{
			get => GetProperty(ref _inventoryScreen_QuickSlot);
			set => SetProperty(ref _inventoryScreen_QuickSlot, value);
		}

		[Ordinal(12)] 
		[RED("inventoryScreen_Consumable")] 
		public CBool InventoryScreen_Consumable
		{
			get => GetProperty(ref _inventoryScreen_Consumable);
			set => SetProperty(ref _inventoryScreen_Consumable, value);
		}

		[Ordinal(13)] 
		[RED("inventoryScreen_Outfit")] 
		public CBool InventoryScreen_Outfit
		{
			get => GetProperty(ref _inventoryScreen_Outfit);
			set => SetProperty(ref _inventoryScreen_Outfit, value);
		}

		[Ordinal(14)] 
		[RED("inventoryScreen_Head")] 
		public CBool InventoryScreen_Head
		{
			get => GetProperty(ref _inventoryScreen_Head);
			set => SetProperty(ref _inventoryScreen_Head, value);
		}

		[Ordinal(15)] 
		[RED("inventoryScreen_Face")] 
		public CBool InventoryScreen_Face
		{
			get => GetProperty(ref _inventoryScreen_Face);
			set => SetProperty(ref _inventoryScreen_Face, value);
		}

		[Ordinal(16)] 
		[RED("inventoryScreen_InnerChest")] 
		public CBool InventoryScreen_InnerChest
		{
			get => GetProperty(ref _inventoryScreen_InnerChest);
			set => SetProperty(ref _inventoryScreen_InnerChest, value);
		}

		[Ordinal(17)] 
		[RED("inventoryScreen_OuterChest")] 
		public CBool InventoryScreen_OuterChest
		{
			get => GetProperty(ref _inventoryScreen_OuterChest);
			set => SetProperty(ref _inventoryScreen_OuterChest, value);
		}
	}
}
