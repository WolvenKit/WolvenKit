using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckEquippedWeapon : AIItemHandlingCondition
	{
		private CHandle<AIArgumentMapping> _slotID;
		private CHandle<AIArgumentMapping> _itemID;
		private TweakDBID _slotIDName;
		private TweakDBID _itemIDName;

		[Ordinal(0)] 
		[RED("slotID")] 
		public CHandle<AIArgumentMapping> SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "slotID", cr2w, this);
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

		[Ordinal(1)] 
		[RED("itemID")] 
		public CHandle<AIArgumentMapping> ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("slotIDName")] 
		public TweakDBID SlotIDName
		{
			get
			{
				if (_slotIDName == null)
				{
					_slotIDName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotIDName", cr2w, this);
				}
				return _slotIDName;
			}
			set
			{
				if (_slotIDName == value)
				{
					return;
				}
				_slotIDName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemIDName")] 
		public TweakDBID ItemIDName
		{
			get
			{
				if (_itemIDName == null)
				{
					_itemIDName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemIDName", cr2w, this);
				}
				return _itemIDName;
			}
			set
			{
				if (_itemIDName == value)
				{
					return;
				}
				_itemIDName = value;
				PropertySet(this);
			}
		}

		public CheckEquippedWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
