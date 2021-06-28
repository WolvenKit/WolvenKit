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
			get => GetProperty(ref _brush);
			set => SetProperty(ref _brush, value);
		}

		[Ordinal(1)] 
		[RED("externalBrush")] 
		public rRef<inkWidgetBrushResource> ExternalBrush
		{
			get => GetProperty(ref _externalBrush);
			set => SetProperty(ref _externalBrush, value);
		}

		public inkBrushWrapper(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
