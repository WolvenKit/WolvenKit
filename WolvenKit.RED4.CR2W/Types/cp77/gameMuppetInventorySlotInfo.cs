using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInventorySlotInfo : CVariable
	{
		private TweakDBID _itemCategory;
		private gameItemID _itemId;
		private CUInt32 _quantity;

		[Ordinal(0)] 
		[RED("itemCategory")] 
		public TweakDBID ItemCategory
		{
			get => GetProperty(ref _itemCategory);
			set => SetProperty(ref _itemCategory, value);
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(2)] 
		[RED("quantity")] 
		public CUInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		public gameMuppetInventorySlotInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
