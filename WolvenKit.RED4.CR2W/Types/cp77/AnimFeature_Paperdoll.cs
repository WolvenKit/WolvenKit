using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Paperdoll : animAnimFeature
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
			get
			{
				if (_genderSelection == null)
				{
					_genderSelection = (CBool) CR2WTypeManager.Create("Bool", "genderSelection", cr2w, this);
				}
				return _genderSelection;
			}
			set
			{
				if (_genderSelection == value)
				{
					return;
				}
				_genderSelection = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("characterCreation")] 
		public CBool CharacterCreation
		{
			get
			{
				if (_characterCreation == null)
				{
					_characterCreation = (CBool) CR2WTypeManager.Create("Bool", "characterCreation", cr2w, this);
				}
				return _characterCreation;
			}
			set
			{
				if (_characterCreation == value)
				{
					return;
				}
				_characterCreation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("characterCreation_Head")] 
		public CBool CharacterCreation_Head
		{
			get
			{
				if (_characterCreation_Head == null)
				{
					_characterCreation_Head = (CBool) CR2WTypeManager.Create("Bool", "characterCreation_Head", cr2w, this);
				}
				return _characterCreation_Head;
			}
			set
			{
				if (_characterCreation_Head == value)
				{
					return;
				}
				_characterCreation_Head = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("characterCreation_Teeth")] 
		public CBool CharacterCreation_Teeth
		{
			get
			{
				if (_characterCreation_Teeth == null)
				{
					_characterCreation_Teeth = (CBool) CR2WTypeManager.Create("Bool", "characterCreation_Teeth", cr2w, this);
				}
				return _characterCreation_Teeth;
			}
			set
			{
				if (_characterCreation_Teeth == value)
				{
					return;
				}
				_characterCreation_Teeth = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("characterCreation_Nails")] 
		public CBool CharacterCreation_Nails
		{
			get
			{
				if (_characterCreation_Nails == null)
				{
					_characterCreation_Nails = (CBool) CR2WTypeManager.Create("Bool", "characterCreation_Nails", cr2w, this);
				}
				return _characterCreation_Nails;
			}
			set
			{
				if (_characterCreation_Nails == value)
				{
					return;
				}
				_characterCreation_Nails = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("characterCreation_Summary")] 
		public CBool CharacterCreation_Summary
		{
			get
			{
				if (_characterCreation_Summary == null)
				{
					_characterCreation_Summary = (CBool) CR2WTypeManager.Create("Bool", "characterCreation_Summary", cr2w, this);
				}
				return _characterCreation_Summary;
			}
			set
			{
				if (_characterCreation_Summary == value)
				{
					return;
				}
				_characterCreation_Summary = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("inventoryScreen")] 
		public CBool InventoryScreen
		{
			get
			{
				if (_inventoryScreen == null)
				{
					_inventoryScreen = (CBool) CR2WTypeManager.Create("Bool", "inventoryScreen", cr2w, this);
				}
				return _inventoryScreen;
			}
			set
			{
				if (_inventoryScreen == value)
				{
					return;
				}
				_inventoryScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("inventoryScreen_Weapon")] 
		public CBool InventoryScreen_Weapon
		{
			get
			{
				if (_inventoryScreen_Weapon == null)
				{
					_inventoryScreen_Weapon = (CBool) CR2WTypeManager.Create("Bool", "inventoryScreen_Weapon", cr2w, this);
				}
				return _inventoryScreen_Weapon;
			}
			set
			{
				if (_inventoryScreen_Weapon == value)
				{
					return;
				}
				_inventoryScreen_Weapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("inventoryScreen_Legs")] 
		public CBool InventoryScreen_Legs
		{
			get
			{
				if (_inventoryScreen_Legs == null)
				{
					_inventoryScreen_Legs = (CBool) CR2WTypeManager.Create("Bool", "inventoryScreen_Legs", cr2w, this);
				}
				return _inventoryScreen_Legs;
			}
			set
			{
				if (_inventoryScreen_Legs == value)
				{
					return;
				}
				_inventoryScreen_Legs = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("inventoryScreen_Feet")] 
		public CBool InventoryScreen_Feet
		{
			get
			{
				if (_inventoryScreen_Feet == null)
				{
					_inventoryScreen_Feet = (CBool) CR2WTypeManager.Create("Bool", "inventoryScreen_Feet", cr2w, this);
				}
				return _inventoryScreen_Feet;
			}
			set
			{
				if (_inventoryScreen_Feet == value)
				{
					return;
				}
				_inventoryScreen_Feet = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("inventoryScreen_Cyberware")] 
		public CBool InventoryScreen_Cyberware
		{
			get
			{
				if (_inventoryScreen_Cyberware == null)
				{
					_inventoryScreen_Cyberware = (CBool) CR2WTypeManager.Create("Bool", "inventoryScreen_Cyberware", cr2w, this);
				}
				return _inventoryScreen_Cyberware;
			}
			set
			{
				if (_inventoryScreen_Cyberware == value)
				{
					return;
				}
				_inventoryScreen_Cyberware = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("inventoryScreen_QuickSlot")] 
		public CBool InventoryScreen_QuickSlot
		{
			get
			{
				if (_inventoryScreen_QuickSlot == null)
				{
					_inventoryScreen_QuickSlot = (CBool) CR2WTypeManager.Create("Bool", "inventoryScreen_QuickSlot", cr2w, this);
				}
				return _inventoryScreen_QuickSlot;
			}
			set
			{
				if (_inventoryScreen_QuickSlot == value)
				{
					return;
				}
				_inventoryScreen_QuickSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("inventoryScreen_Consumable")] 
		public CBool InventoryScreen_Consumable
		{
			get
			{
				if (_inventoryScreen_Consumable == null)
				{
					_inventoryScreen_Consumable = (CBool) CR2WTypeManager.Create("Bool", "inventoryScreen_Consumable", cr2w, this);
				}
				return _inventoryScreen_Consumable;
			}
			set
			{
				if (_inventoryScreen_Consumable == value)
				{
					return;
				}
				_inventoryScreen_Consumable = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("inventoryScreen_Outfit")] 
		public CBool InventoryScreen_Outfit
		{
			get
			{
				if (_inventoryScreen_Outfit == null)
				{
					_inventoryScreen_Outfit = (CBool) CR2WTypeManager.Create("Bool", "inventoryScreen_Outfit", cr2w, this);
				}
				return _inventoryScreen_Outfit;
			}
			set
			{
				if (_inventoryScreen_Outfit == value)
				{
					return;
				}
				_inventoryScreen_Outfit = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("inventoryScreen_Head")] 
		public CBool InventoryScreen_Head
		{
			get
			{
				if (_inventoryScreen_Head == null)
				{
					_inventoryScreen_Head = (CBool) CR2WTypeManager.Create("Bool", "inventoryScreen_Head", cr2w, this);
				}
				return _inventoryScreen_Head;
			}
			set
			{
				if (_inventoryScreen_Head == value)
				{
					return;
				}
				_inventoryScreen_Head = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("inventoryScreen_Face")] 
		public CBool InventoryScreen_Face
		{
			get
			{
				if (_inventoryScreen_Face == null)
				{
					_inventoryScreen_Face = (CBool) CR2WTypeManager.Create("Bool", "inventoryScreen_Face", cr2w, this);
				}
				return _inventoryScreen_Face;
			}
			set
			{
				if (_inventoryScreen_Face == value)
				{
					return;
				}
				_inventoryScreen_Face = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("inventoryScreen_InnerChest")] 
		public CBool InventoryScreen_InnerChest
		{
			get
			{
				if (_inventoryScreen_InnerChest == null)
				{
					_inventoryScreen_InnerChest = (CBool) CR2WTypeManager.Create("Bool", "inventoryScreen_InnerChest", cr2w, this);
				}
				return _inventoryScreen_InnerChest;
			}
			set
			{
				if (_inventoryScreen_InnerChest == value)
				{
					return;
				}
				_inventoryScreen_InnerChest = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("inventoryScreen_OuterChest")] 
		public CBool InventoryScreen_OuterChest
		{
			get
			{
				if (_inventoryScreen_OuterChest == null)
				{
					_inventoryScreen_OuterChest = (CBool) CR2WTypeManager.Create("Bool", "inventoryScreen_OuterChest", cr2w, this);
				}
				return _inventoryScreen_OuterChest;
			}
			set
			{
				if (_inventoryScreen_OuterChest == value)
				{
					return;
				}
				_inventoryScreen_OuterChest = value;
				PropertySet(this);
			}
		}

		public AnimFeature_Paperdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
