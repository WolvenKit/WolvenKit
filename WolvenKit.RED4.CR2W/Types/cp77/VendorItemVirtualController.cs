using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorItemVirtualController : inkVirtualCompoundItemController
	{
		private CHandle<VendorInventoryItemData> _data;
		private wCHandle<InventoryItemDisplayController> _itemViewController;
		private CBool _isSpawnInProgress;

		[Ordinal(15)] 
		[RED("data")] 
		public CHandle<VendorInventoryItemData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(16)] 
		[RED("itemViewController")] 
		public wCHandle<InventoryItemDisplayController> ItemViewController
		{
			get => GetProperty(ref _itemViewController);
			set => SetProperty(ref _itemViewController, value);
		}

		[Ordinal(17)] 
		[RED("isSpawnInProgress")] 
		public CBool IsSpawnInProgress
		{
			get => GetProperty(ref _isSpawnInProgress);
			set => SetProperty(ref _isSpawnInProgress, value);
		}

		public VendorItemVirtualController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
