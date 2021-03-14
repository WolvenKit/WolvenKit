using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workUnequipPropAction : workIWorkspotItemAction
	{
		private CName _itemId;

		[Ordinal(0)] 
		[RED("itemId")] 
		public CName ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (CName) CR2WTypeManager.Create("CName", "itemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		public workUnequipPropAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
