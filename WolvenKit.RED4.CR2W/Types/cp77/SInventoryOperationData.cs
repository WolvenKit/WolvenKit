using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SInventoryOperationData : CVariable
	{
		private TweakDBID _itemName;
		private CInt32 _quantity;
		private CEnum<EItemOperationType> _operationType;

		[Ordinal(0)] 
		[RED("itemName")] 
		public TweakDBID ItemName
		{
			get
			{
				if (_itemName == null)
				{
					_itemName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemName", cr2w, this);
				}
				return _itemName;
			}
			set
			{
				if (_itemName == value)
				{
					return;
				}
				_itemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("operationType")] 
		public CEnum<EItemOperationType> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<EItemOperationType>) CR2WTypeManager.Create("EItemOperationType", "operationType", cr2w, this);
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

		public SInventoryOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
