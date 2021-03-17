using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameInventory : gameComponent
	{
		private CBool _saveInventory;
		private CEnum<gameSharedInventoryTag> _inventoryTag;
		private CBool _noInitialization;

		[Ordinal(4)] 
		[RED("saveInventory")] 
		public CBool SaveInventory
		{
			get => GetProperty(ref _saveInventory);
			set => SetProperty(ref _saveInventory, value);
		}

		[Ordinal(5)] 
		[RED("inventoryTag")] 
		public CEnum<gameSharedInventoryTag> InventoryTag
		{
			get => GetProperty(ref _inventoryTag);
			set => SetProperty(ref _inventoryTag, value);
		}

		[Ordinal(6)] 
		[RED("noInitialization")] 
		public CBool NoInitialization
		{
			get => GetProperty(ref _noInitialization);
			set => SetProperty(ref _noInitialization, value);
		}

		public gameInventory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
