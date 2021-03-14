using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCpoPickableItem : gameObject
	{
		private TweakDBID _itemIDToEquip;
		private CInt32 _quickSlotID;

		[Ordinal(40)] 
		[RED("itemIDToEquip")] 
		public TweakDBID ItemIDToEquip
		{
			get
			{
				if (_itemIDToEquip == null)
				{
					_itemIDToEquip = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemIDToEquip", cr2w, this);
				}
				return _itemIDToEquip;
			}
			set
			{
				if (_itemIDToEquip == value)
				{
					return;
				}
				_itemIDToEquip = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("quickSlotID")] 
		public CInt32 QuickSlotID
		{
			get
			{
				if (_quickSlotID == null)
				{
					_quickSlotID = (CInt32) CR2WTypeManager.Create("Int32", "quickSlotID", cr2w, this);
				}
				return _quickSlotID;
			}
			set
			{
				if (_quickSlotID == value)
				{
					return;
				}
				_quickSlotID = value;
				PropertySet(this);
			}
		}

		public gameCpoPickableItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
