using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemChooserItemHoverOut : redEvent
	{
		private CHandle<inkPointerEvent> _sourceEvent;

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

		public ItemChooserItemHoverOut(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
