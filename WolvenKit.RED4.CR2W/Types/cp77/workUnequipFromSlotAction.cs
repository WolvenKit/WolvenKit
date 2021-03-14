using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workUnequipFromSlotAction : workIWorkspotItemAction
	{
		private TweakDBID _itemSlot;

		[Ordinal(0)] 
		[RED("itemSlot")] 
		public TweakDBID ItemSlot
		{
			get
			{
				if (_itemSlot == null)
				{
					_itemSlot = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemSlot", cr2w, this);
				}
				return _itemSlot;
			}
			set
			{
				if (_itemSlot == value)
				{
					return;
				}
				_itemSlot = value;
				PropertySet(this);
			}
		}

		public workUnequipFromSlotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
