using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SItemTransaction : CVariable
	{
		private gameSItemStack _itemStack;
		private CInt32 _pricePerItem;

		[Ordinal(0)] 
		[RED("itemStack")] 
		public gameSItemStack ItemStack
		{
			get => GetProperty(ref _itemStack);
			set => SetProperty(ref _itemStack, value);
		}

		[Ordinal(1)] 
		[RED("pricePerItem")] 
		public CInt32 PricePerItem
		{
			get => GetProperty(ref _pricePerItem);
			set => SetProperty(ref _pricePerItem, value);
		}

		public SItemTransaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
