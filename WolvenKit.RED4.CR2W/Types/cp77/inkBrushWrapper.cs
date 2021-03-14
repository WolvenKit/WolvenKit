using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkBrushWrapper : CVariable
	{
		private CHandle<inkWidgetBrush> _brush;
		private rRef<inkWidgetBrushResource> _externalBrush;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("externalBrush")] 
		public rRef<inkWidgetBrushResource> ExternalBrush
		{
			get
			{
				if (_externalBrush == null)
				{
					_externalBrush = (rRef<inkWidgetBrushResource>) CR2WTypeManager.Create("rRef:inkWidgetBrushResource", "externalBrush", cr2w, this);
				}
				return _externalBrush;
			}
			set
			{
				if (_externalBrush == value)
				{
					return;
				}
				_externalBrush = value;
				PropertySet(this);
			}
		}

		public inkBrushWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
