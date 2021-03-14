using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemRecipe : CVariable
	{
		private TweakDBID _targetItem;
		private CBool _isHidden;
		private CInt32 _amount;

		[Ordinal(0)] 
		[RED("targetItem")] 
		public TweakDBID TargetItem
		{
			get
			{
				if (_targetItem == null)
				{
					_targetItem = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "targetItem", cr2w, this);
				}
				return _targetItem;
			}
			set
			{
				if (_targetItem == value)
				{
					return;
				}
				_targetItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get
			{
				if (_isHidden == null)
				{
					_isHidden = (CBool) CR2WTypeManager.Create("Bool", "isHidden", cr2w, this);
				}
				return _isHidden;
			}
			set
			{
				if (_isHidden == value)
				{
					return;
				}
				_isHidden = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public ItemRecipe(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
