using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InstallModConfirmationData : IScriptable
	{
		private gameItemID _itemId;
		private gameItemID _partId;
		private TweakDBID _slotID;
		private gameTelemetryInventoryItem _telemetryItemData;
		private gameTelemetryInventoryItem _telemetryPartData;

		[Ordinal(0)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("partId")] 
		public gameItemID PartId
		{
			get
			{
				if (_partId == null)
				{
					_partId = (gameItemID) CR2WTypeManager.Create("gameItemID", "partId", cr2w, this);
				}
				return _partId;
			}
			set
			{
				if (_partId == value)
				{
					return;
				}
				_partId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("telemetryItemData")] 
		public gameTelemetryInventoryItem TelemetryItemData
		{
			get
			{
				if (_telemetryItemData == null)
				{
					_telemetryItemData = (gameTelemetryInventoryItem) CR2WTypeManager.Create("gameTelemetryInventoryItem", "telemetryItemData", cr2w, this);
				}
				return _telemetryItemData;
			}
			set
			{
				if (_telemetryItemData == value)
				{
					return;
				}
				_telemetryItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("telemetryPartData")] 
		public gameTelemetryInventoryItem TelemetryPartData
		{
			get
			{
				if (_telemetryPartData == null)
				{
					_telemetryPartData = (gameTelemetryInventoryItem) CR2WTypeManager.Create("gameTelemetryInventoryItem", "telemetryPartData", cr2w, this);
				}
				return _telemetryPartData;
			}
			set
			{
				if (_telemetryPartData == value)
				{
					return;
				}
				_telemetryPartData = value;
				PropertySet(this);
			}
		}

		public InstallModConfirmationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
