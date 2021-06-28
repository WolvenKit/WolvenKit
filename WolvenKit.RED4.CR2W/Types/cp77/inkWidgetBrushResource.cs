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
			get => GetProperty(ref _brush);
			set => SetProperty(ref _brush, value);
		}

		public inkWidgetBrushResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
