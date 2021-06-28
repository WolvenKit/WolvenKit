using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextMotherTongueController : inkWidgetLogicController
	{
		private inkTextWidgetReference _preTranslatedTextWidget;
		private inkTextWidgetReference _postTranslatedTextWidget;
		private inkRichTextBoxWidgetReference _nativeTextWidget;
		private inkTextWidgetReference _translatedTextWidget;

		[Ordinal(1)] 
		[RED("preTranslatedTextWidget")] 
		public inkTextWidgetReference PreTranslatedTextWidget
		{
			get => GetProperty(ref _preTranslatedTextWidget);
			set => SetProperty(ref _preTranslatedTextWidget, value);
		}

		[Ordinal(2)] 
		[RED("postTranslatedTextWidget")] 
		public inkTextWidgetReference PostTranslatedTextWidget
		{
			get => GetProperty(ref _postTranslatedTextWidget);
			set => SetProperty(ref _postTranslatedTextWidget, value);
		}

		[Ordinal(3)] 
		[RED("nativeTextWidget")] 
		public inkRichTextBoxWidgetReference NativeTextWidget
		{
			get => GetProperty(ref _nativeTextWidget);
			set => SetProperty(ref _nativeTextWidget, value);
		}

		[Ordinal(4)] 
		[RED("translatedTextWidget")] 
		public inkTextWidgetReference TranslatedTextWidget
		{
			get => GetProperty(ref _translatedTextWidget);
			set => SetProperty(ref _translatedTextWidget, value);
		}

		public inkTextMotherTongueController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
