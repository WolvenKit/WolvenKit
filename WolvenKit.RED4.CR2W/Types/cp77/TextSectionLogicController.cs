using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TextSectionLogicController : inkWidgetLogicController
	{
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<inkTextWidget> _textWidget;
		private CHandle<inkanimProxy> _showAnimProxy;

		[Ordinal(1)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(2)] 
		[RED("textWidget")] 
		public wCHandle<inkTextWidget> TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		[Ordinal(3)] 
		[RED("showAnimProxy")] 
		public CHandle<inkanimProxy> ShowAnimProxy
		{
			get => GetProperty(ref _showAnimProxy);
			set => SetProperty(ref _showAnimProxy, value);
		}

		public TextSectionLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
