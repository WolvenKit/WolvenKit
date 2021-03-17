using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextKiroshiAnimationController : inkTextAnimationController
	{
		private CFloat _timeToSkip;
		private CString _nativeText;
		private inkTextWidgetReference _preTranslatedTextWidget;
		private inkTextWidgetReference _postTranslatedTextWidget;
		private inkRichTextBoxWidgetReference _nativeTextWidget;
		private inkTextWidgetReference _translatedTextWidget;

		[Ordinal(8)] 
		[RED("timeToSkip")] 
		public CFloat TimeToSkip
		{
			get => GetProperty(ref _timeToSkip);
			set => SetProperty(ref _timeToSkip, value);
		}

		[Ordinal(9)] 
		[RED("nativeText")] 
		public CString NativeText
		{
			get => GetProperty(ref _nativeText);
			set => SetProperty(ref _nativeText, value);
		}

		[Ordinal(10)] 
		[RED("preTranslatedTextWidget")] 
		public inkTextWidgetReference PreTranslatedTextWidget
		{
			get => GetProperty(ref _preTranslatedTextWidget);
			set => SetProperty(ref _preTranslatedTextWidget, value);
		}

		[Ordinal(11)] 
		[RED("postTranslatedTextWidget")] 
		public inkTextWidgetReference PostTranslatedTextWidget
		{
			get => GetProperty(ref _postTranslatedTextWidget);
			set => SetProperty(ref _postTranslatedTextWidget, value);
		}

		[Ordinal(12)] 
		[RED("nativeTextWidget")] 
		public inkRichTextBoxWidgetReference NativeTextWidget
		{
			get => GetProperty(ref _nativeTextWidget);
			set => SetProperty(ref _nativeTextWidget, value);
		}

		[Ordinal(13)] 
		[RED("translatedTextWidget")] 
		public inkTextWidgetReference TranslatedTextWidget
		{
			get => GetProperty(ref _translatedTextWidget);
			set => SetProperty(ref _translatedTextWidget, value);
		}

		public inkTextKiroshiAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
