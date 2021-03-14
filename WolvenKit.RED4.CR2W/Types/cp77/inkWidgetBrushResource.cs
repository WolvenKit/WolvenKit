using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetBrushResource : CResource
	{
		private CHandle<inkWidgetBrush> _brush;

		[Ordinal(1)] 
		[RED("brush")] 
		public CHandle<inkWidgetBrush> Brush
		{
			get
			{
				if (_brush == null)
				{
					_brush = (CHandle<inkWidgetBrush>) CR2WTypeManager.Create("handle:inkWidgetBrush", "brush", cr2w, this);
				}
				return _brush;
			}
			set
			{
				if (_brush == value)
				{
					return;
				}
				_brush = value;
				PropertySet(this);
			}
		}

		public inkWidgetBrushResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
