using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GarmentItemPreviewGameController : gameuiInventoryPuppetPreviewGameController
	{
		private CHandle<InventoryItemPreviewData> _data;
		private TweakDBID _placementSlot;
		private gameItemID _initialItem;
		private gameItemID _givenItem;

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(10)] 
		[RED("placementSlot")] 
		public TweakDBID PlacementSlot
		{
			get => GetProperty(ref _placementSlot);
			set => SetProperty(ref _placementSlot, value);
		}

		[Ordinal(11)] 
		[RED("initialItem")] 
		public gameItemID InitialItem
		{
			get => GetProperty(ref _initialItem);
			set => SetProperty(ref _initialItem, value);
		}

		[Ordinal(12)] 
		[RED("givenItem")] 
		public gameItemID GivenItem
		{
			get => GetProperty(ref _givenItem);
			set => SetProperty(ref _givenItem, value);
		}

		public GarmentItemPreviewGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
