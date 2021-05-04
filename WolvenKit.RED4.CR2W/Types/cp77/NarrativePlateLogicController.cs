using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NarrativePlateLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _textWidget;
		private inkWidgetReference _captionWidget;
		private inkWidgetReference _root;

		[Ordinal(1)] 
		[RED("textWidget")] 
		public inkWidgetReference TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		[Ordinal(2)] 
		[RED("captionWidget")] 
		public inkWidgetReference CaptionWidget
		{
			get => GetProperty(ref _captionWidget);
			set => SetProperty(ref _captionWidget, value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		public NarrativePlateLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
