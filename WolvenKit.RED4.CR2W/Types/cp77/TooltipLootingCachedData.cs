using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipLootingCachedData : IScriptable
	{
		private wCHandle<gameItemData> _externalItemData;
		private wCHandle<gamedataItem_Record> _itemRecord;
		private wCHandle<gameItemData> _comparisionItemData;
		private CHandle<MinimalLootingListItemData> _lootingData;

		[Ordinal(0)] 
		[RED("externalItemData")] 
		public wCHandle<gameItemData> ExternalItemData
		{
			get
			{
				if (_externalItemData == null)
				{
					_externalItemData = (wCHandle<gameItemData>) CR2WTypeManager.Create("whandle:gameItemData", "externalItemData", cr2w, this);
				}
				return _externalItemData;
			}
			set
			{
				if (_externalItemData == value)
				{
					return;
				}
				_externalItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemRecord")] 
		public wCHandle<gamedataItem_Record> ItemRecord
		{
			get
			{
				if (_itemRecord == null)
				{
					_itemRecord = (wCHandle<gamedataItem_Record>) CR2WTypeManager.Create("whandle:gamedataItem_Record", "itemRecord", cr2w, this);
				}
				return _itemRecord;
			}
			set
			{
				if (_itemRecord == value)
				{
					return;
				}
				_itemRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("comparisionItemData")] 
		public wCHandle<gameItemData> ComparisionItemData
		{
			get
			{
				if (_comparisionItemData == null)
				{
					_comparisionItemData = (wCHandle<gameItemData>) CR2WTypeManager.Create("whandle:gameItemData", "comparisionItemData", cr2w, this);
				}
				return _comparisionItemData;
			}
			set
			{
				if (_comparisionItemData == value)
				{
					return;
				}
				_comparisionItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lootingData")] 
		public CHandle<MinimalLootingListItemData> LootingData
		{
			get
			{
				if (_lootingData == null)
				{
					_lootingData = (CHandle<MinimalLootingListItemData>) CR2WTypeManager.Create("handle:MinimalLootingListItemData", "lootingData", cr2w, this);
				}
				return _lootingData;
			}
			set
			{
				if (_lootingData == value)
				{
					return;
				}
				_lootingData = value;
				PropertySet(this);
			}
		}

		public TooltipLootingCachedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
