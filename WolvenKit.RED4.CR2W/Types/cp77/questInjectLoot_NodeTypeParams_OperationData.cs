using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInjectLoot_NodeTypeParams_OperationData : CVariable
	{
		private CEnum<questInjectLootOperationType> _operationType;
		private TweakDBID _itemTDBID;
		private CInt32 _quantity;

		[Ordinal(0)] 
		[RED("operationType")] 
		public CEnum<questInjectLootOperationType> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<questInjectLootOperationType>) CR2WTypeManager.Create("questInjectLootOperationType", "operationType", cr2w, this);
				}
				return _operationType;
			}
			set
			{
				if (_operationType == value)
				{
					return;
				}
				_operationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemTDBID")] 
		public TweakDBID ItemTDBID
		{
			get
			{
				if (_itemTDBID == null)
				{
					_itemTDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemTDBID", cr2w, this);
				}
				return _itemTDBID;
			}
			set
			{
				if (_itemTDBID == value)
				{
					return;
				}
				_itemTDBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get
			{
				if (_quantity == null)
				{
					_quantity = (CInt32) CR2WTypeManager.Create("Int32", "quantity", cr2w, this);
				}
				return _quantity;
			}
			set
			{
				if (_quantity == value)
				{
					return;
				}
				_quantity = value;
				PropertySet(this);
			}
		}

		public questInjectLoot_NodeTypeParams_OperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
