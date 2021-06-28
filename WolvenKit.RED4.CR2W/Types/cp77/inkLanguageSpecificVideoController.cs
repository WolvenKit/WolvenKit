using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLanguageSpecificVideoController : inkWidgetLogicController
	{
		private CBool _isLooped;
		private raRef<Bink> _specificVideoForLanguage;
		private CArray<CEnum<inkLanguageId>> _languages;
		private raRef<Bink> _fallbackVideo;

		[Ordinal(1)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetProperty(ref _isLooped);
			set => SetProperty(ref _isLooped, value);
		}

		[Ordinal(2)] 
		[RED("specificVideoForLanguage")] 
		public raRef<Bink> SpecificVideoForLanguage
		{
			get => GetProperty(ref _specificVideoForLanguage);
			set => SetProperty(ref _specificVideoForLanguage, value);
		}

		[Ordinal(3)] 
		[RED("languages")] 
		public CArray<CEnum<inkLanguageId>> Languages
		{
			get => GetProperty(ref _languages);
			set => SetProperty(ref _languages, value);
		}

		[Ordinal(4)] 
		[RED("fallbackVideo")] 
		public raRef<Bink> FallbackVideo
		{
			get => GetProperty(ref _fallbackVideo);
			set => SetProperty(ref _fallbackVideo, value);
		}

		public inkLanguageSpecificVideoController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
