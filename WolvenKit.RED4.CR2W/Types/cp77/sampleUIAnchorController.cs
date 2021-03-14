using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIAnchorController : inkWidgetLogicController
	{
		private inkRectangleWidgetReference _rectangleAnchor;

		[Ordinal(1)] 
		[RED("rectangleAnchor")] 
		public inkRectangleWidgetReference RectangleAnchor
		{
			get
			{
				if (_rectangleAnchor == null)
				{
					_rectangleAnchor = (inkRectangleWidgetReference) CR2WTypeManager.Create("inkRectangleWidgetReference", "rectangleAnchor", cr2w, this);
				}
				return _rectangleAnchor;
			}
			set
			{
				if (_rectangleAnchor == value)
				{
					return;
				}
				_rectangleAnchor = value;
				PropertySet(this);
			}
		}

		public sampleUIAnchorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
