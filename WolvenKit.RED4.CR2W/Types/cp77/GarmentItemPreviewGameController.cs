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
			get
			{
				if (_data == null)
				{
					_data = (CHandle<InventoryItemPreviewData>) CR2WTypeManager.Create("handle:InventoryItemPreviewData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("placementSlot")] 
		public TweakDBID PlacementSlot
		{
			get
			{
				if (_placementSlot == null)
				{
					_placementSlot = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "placementSlot", cr2w, this);
				}
				return _placementSlot;
			}
			set
			{
				if (_placementSlot == value)
				{
					return;
				}
				_placementSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("initialItem")] 
		public gameItemID InitialItem
		{
			get
			{
				if (_initialItem == null)
				{
					_initialItem = (gameItemID) CR2WTypeManager.Create("gameItemID", "initialItem", cr2w, this);
				}
				return _initialItem;
			}
			set
			{
				if (_initialItem == value)
				{
					return;
				}
				_initialItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("givenItem")] 
		public gameItemID GivenItem
		{
			get
			{
				if (_givenItem == null)
				{
					_givenItem = (gameItemID) CR2WTypeManager.Create("gameItemID", "givenItem", cr2w, this);
				}
				return _givenItem;
			}
			set
			{
				if (_givenItem == value)
				{
					return;
				}
				_givenItem = value;
				PropertySet(this);
			}
		}

		public GarmentItemPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
