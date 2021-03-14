using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workAnimClipWithItem : workAnimClip
	{
		private CArray<CHandle<workIWorkspotItemAction>> _itemActions;

		[Ordinal(4)] 
		[RED("itemActions")] 
		public CArray<CHandle<workIWorkspotItemAction>> ItemActions
		{
			get
			{
				if (_itemActions == null)
				{
					_itemActions = (CArray<CHandle<workIWorkspotItemAction>>) CR2WTypeManager.Create("array:handle:workIWorkspotItemAction", "itemActions", cr2w, this);
				}
				return _itemActions;
			}
			set
			{
				if (_itemActions == value)
				{
					return;
				}
				_itemActions = value;
				PropertySet(this);
			}
		}

		public workAnimClipWithItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
