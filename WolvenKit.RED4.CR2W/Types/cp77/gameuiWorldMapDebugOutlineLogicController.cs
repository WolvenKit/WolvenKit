using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapDebugOutlineLogicController : inkWidgetLogicController
	{
		private inkShapeWidgetReference _outlineWidget;

		[Ordinal(1)] 
		[RED("outlineWidget")] 
		public inkShapeWidgetReference OutlineWidget
		{
			get
			{
				if (_outlineWidget == null)
				{
					_outlineWidget = (inkShapeWidgetReference) CR2WTypeManager.Create("inkShapeWidgetReference", "outlineWidget", cr2w, this);
				}
				return _outlineWidget;
			}
			set
			{
				if (_outlineWidget == value)
				{
					return;
				}
				_outlineWidget = value;
				PropertySet(this);
			}
		}

		public gameuiWorldMapDebugOutlineLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
