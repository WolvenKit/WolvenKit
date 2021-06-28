using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIPathAndReferenceGameController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _textWidget;
		private inkWidgetPath _imageWidgetPath;
		private wCHandle<inkImageWidget> _imageWidget;
		private wCHandle<inkBasePanelWidget> _panelWidget;

		[Ordinal(2)] 
		[RED("textWidget")] 
		public inkTextWidgetReference TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		[Ordinal(3)] 
		[RED("imageWidgetPath")] 
		public inkWidgetPath ImageWidgetPath
		{
			get => GetProperty(ref _imageWidgetPath);
			set => SetProperty(ref _imageWidgetPath, value);
		}

		[Ordinal(4)] 
		[RED("imageWidget")] 
		public wCHandle<inkImageWidget> ImageWidget
		{
			get => GetProperty(ref _imageWidget);
			set => SetProperty(ref _imageWidget, value);
		}

		[Ordinal(5)] 
		[RED("panelWidget")] 
		public wCHandle<inkBasePanelWidget> PanelWidget
		{
			get => GetProperty(ref _panelWidget);
			set => SetProperty(ref _panelWidget, value);
		}

		public sampleUIPathAndReferenceGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
