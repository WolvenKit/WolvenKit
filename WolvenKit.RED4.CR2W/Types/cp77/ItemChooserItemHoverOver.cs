using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemChooserItemHoverOver : redEvent
	{
		private CHandle<inkPointerEvent> _sourceEvent;
		private wCHandle<InventoryItemDisplayController> _targetItem;

		[Ordinal(0)] 
		[RED("sourceEvent")] 
		public CHandle<inkPointerEvent> SourceEvent
		{
			get
			{
				if (_sourceEvent == null)
				{
					_sourceEvent = (CHandle<inkPointerEvent>) CR2WTypeManager.Create("handle:inkPointerEvent", "sourceEvent", cr2w, this);
				}
				return _sourceEvent;
			}
			set
			{
				if (_sourceEvent == value)
				{
					return;
				}
				_sourceEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetItem")] 
		public wCHandle<InventoryItemDisplayController> TargetItem
		{
			get
			{
				if (_targetItem == null)
				{
					_targetItem = (wCHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("whandle:InventoryItemDisplayController", "targetItem", cr2w, this);
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

		public ItemChooserItemHoverOver(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
