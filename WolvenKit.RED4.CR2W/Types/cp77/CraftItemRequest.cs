using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftItemRequest : gamePlayerScriptableSystemRequest
	{
		private wCHandle<gameObject> _target;
		private CHandle<gamedataItem_Record> _itemRecord;
		private CInt32 _amount;

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("itemRecord")] 
		public CHandle<gamedataItem_Record> ItemRecord
		{
			get
			{
				if (_itemRecord == null)
				{
					_itemRecord = (CHandle<gamedataItem_Record>) CR2WTypeManager.Create("handle:gamedataItem_Record", "itemRecord", cr2w, this);
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

		[Ordinal(3)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get
			{
				if (_amount == null)
				{
					_amount = (CInt32) CR2WTypeManager.Create("Int32", "amount", cr2w, this);
				}
				return _amount;
			}
			set
			{
				if (_amount == value)
				{
					return;
				}
				_amount = value;
				PropertySet(this);
			}
		}

		public CraftItemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
