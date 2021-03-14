using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetRunnerListItem : inkWidgetLogicController
	{
		private inkWidgetReference _highlight;

		[Ordinal(1)] 
		[RED("highlight")] 
		public inkWidgetReference Highlight
		{
			get
			{
				if (_highlight == null)
				{
					_highlight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "highlight", cr2w, this);
				}
				return _highlight;
			}
			set
			{
				if (_highlight == value)
				{
					return;
				}
				_highlight = value;
				PropertySet(this);
			}
		}

		public NetRunnerListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
