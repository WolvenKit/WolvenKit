using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemComparableTypesCache : IScriptable
	{
		private CEnum<gamedataItemType> _itemType;
		private wCHandle<gamedataItemType_Record> _itemTypeRecord;
		private CArray<CEnum<gamedataItemType>> _comparableTypes;
		private CArray<wCHandle<gamedataItemType_Record>> _comparableRecordTypes;

		[Ordinal(0)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get
			{
				if (_itemType == null)
				{
					_itemType = (CEnum<gamedataItemType>) CR2WTypeManager.Create("gamedataItemType", "itemType", cr2w, this);
				}
				return _itemType;
			}
			set
			{
				if (_itemType == value)
				{
					return;
				}
				_itemType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemTypeRecord")] 
		public wCHandle<gamedataItemType_Record> ItemTypeRecord
		{
			get
			{
				if (_itemTypeRecord == null)
				{
					_itemTypeRecord = (wCHandle<gamedataItemType_Record>) CR2WTypeManager.Create("whandle:gamedataItemType_Record", "itemTypeRecord", cr2w, this);
				}
				return _itemTypeRecord;
			}
			set
			{
				if (_itemTypeRecord == value)
				{
					return;
				}
				_itemTypeRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("comparableTypes")] 
		public CArray<CEnum<gamedataItemType>> ComparableTypes
		{
			get
			{
				if (_comparableTypes == null)
				{
					_comparableTypes = (CArray<CEnum<gamedataItemType>>) CR2WTypeManager.Create("array:gamedataItemType", "comparableTypes", cr2w, this);
				}
				return _comparableTypes;
			}
			set
			{
				if (_comparableTypes == value)
				{
					return;
				}
				_comparableTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("comparableRecordTypes")] 
		public CArray<wCHandle<gamedataItemType_Record>> ComparableRecordTypes
		{
			get
			{
				if (_comparableRecordTypes == null)
				{
					_comparableRecordTypes = (CArray<wCHandle<gamedataItemType_Record>>) CR2WTypeManager.Create("array:whandle:gamedataItemType_Record", "comparableRecordTypes", cr2w, this);
				}
				return _comparableRecordTypes;
			}
			set
			{
				if (_comparableRecordTypes == value)
				{
					return;
				}
				_comparableRecordTypes = value;
				PropertySet(this);
			}
		}

		public ItemComparableTypesCache(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
