using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotUIStructure : CVariable
	{
		private CInt32 _itemIndex;
		private CBool _operationResult;

		[Ordinal(0)] 
		[RED("ItemIndex")] 
		public CInt32 ItemIndex
		{
			get
			{
				if (_itemIndex == null)
				{
					_itemIndex = (CInt32) CR2WTypeManager.Create("Int32", "ItemIndex", cr2w, this);
				}
				return _itemIndex;
			}
			set
			{
				if (_itemIndex == value)
				{
					return;
				}
				_itemIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("OperationResult")] 
		public CBool OperationResult
		{
			get
			{
				if (_operationResult == null)
				{
					_operationResult = (CBool) CR2WTypeManager.Create("Bool", "OperationResult", cr2w, this);
				}
				return _operationResult;
			}
			set
			{
				if (_operationResult == value)
				{
					return;
				}
				_operationResult = value;
				PropertySet(this);
			}
		}

		public QuickSlotUIStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
