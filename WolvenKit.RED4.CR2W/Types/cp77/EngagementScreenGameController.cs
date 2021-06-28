using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EngagementScreenGameController : gameuiMenuGameController
	{
		private inkVideoWidgetReference _backgroundVideo;
		private inkRichTextBoxWidgetReference _text;
		private inkRichTextBoxWidgetReference _textShadow;
		private inkCompoundWidgetReference _textContainer;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;

		[Ordinal(3)] 
		[RED("backgroundVideo")] 
		public inkVideoWidgetReference BackgroundVideo
		{
			get => GetProperty(ref _backgroundVideo);
			set => SetProperty(ref _backgroundVideo, value);
		}

		[Ordinal(4)] 
		[RED("text")] 
		public inkRichTextBoxWidgetReference Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(5)] 
		[RED("textShadow")] 
		public inkRichTextBoxWidgetReference TextShadow
		{
			get => GetProperty(ref _textShadow);
			set => SetProperty(ref _textShadow, value);
		}

		[Ordinal(6)] 
		[RED("textContainer")] 
		public inkCompoundWidgetReference TextContainer
		{
			get => GetProperty(ref _textContainer);
			set => SetProperty(ref _textContainer, value);
		}

		[Ordinal(7)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		public EngagementScreenGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
