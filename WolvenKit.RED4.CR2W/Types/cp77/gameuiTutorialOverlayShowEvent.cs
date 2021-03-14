using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialOverlayShowEvent : redEvent
	{
		private CName _itemName;

		[Ordinal(0)] 
		[RED("itemName")] 
		public CName ItemName
		{
			get
			{
				if (_itemName == null)
				{
					_itemName = (CName) CR2WTypeManager.Create("CName", "itemName", cr2w, this);
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

		public gameuiTutorialOverlayShowEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
