using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDefaultHighlightEvent : redEvent
	{
		private CHandle<HighlightEditableData> _highlightData;

		[Ordinal(0)] 
		[RED("highlightData")] 
		public CHandle<HighlightEditableData> HighlightData
		{
			get
			{
				if (_highlightData == null)
				{
					_highlightData = (CHandle<HighlightEditableData>) CR2WTypeManager.Create("handle:HighlightEditableData", "highlightData", cr2w, this);
				}
				return _highlightData;
			}
			set
			{
				if (_highlightData == value)
				{
					return;
				}
				_highlightData = value;
				PropertySet(this);
			}
		}

		public SetDefaultHighlightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
