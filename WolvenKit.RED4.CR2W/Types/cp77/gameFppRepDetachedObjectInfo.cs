using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFppRepDetachedObjectInfo : CVariable
	{
		private TweakDBID _slotID;
		private TweakDBID _itemTDBID;

		[Ordinal(0)] 
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

		public gameFppRepDetachedObjectInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
