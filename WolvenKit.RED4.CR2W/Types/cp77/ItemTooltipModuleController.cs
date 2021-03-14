using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModuleController : inkWidgetLogicController
	{
		private inkWidgetReference _lineWidget;

		[Ordinal(1)] 
		[RED("lineWidget")] 
		public inkWidgetReference LineWidget
		{
			get
			{
				if (_lineWidget == null)
				{
					_lineWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "lineWidget", cr2w, this);
				}
				return _lineWidget;
			}
			set
			{
				if (_lineWidget == value)
				{
					return;
				}
				_lineWidget = value;
				PropertySet(this);
			}
		}

		public ItemTooltipModuleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
