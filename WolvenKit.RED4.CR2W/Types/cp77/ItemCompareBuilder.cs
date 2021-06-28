using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemCompareBuilder : IScriptable
	{
		private InventoryItemData _item1;
		private InventoryItemData _item2;
		private CHandle<CompareBuilder> _compareBuilder;

		[Ordinal(0)] 
		[RED("item1")] 
		public InventoryItemData Item1
		{
			get => GetProperty(ref _item1);
			set => SetProperty(ref _item1, value);
		}

		[Ordinal(1)] 
		[RED("item2")] 
		public InventoryItemData Item2
		{
			get => GetProperty(ref _item2);
			set => SetProperty(ref _item2, value);
		}

		[Ordinal(2)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get => GetProperty(ref _compareBuilder);
			set => SetProperty(ref _compareBuilder, value);
		}

		public ItemCompareBuilder(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
