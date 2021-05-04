using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDialogDisplayString : CVariable
	{
		private CString _text;
		private CString _translation;
		private CString _preTranslatedText;
		private CString _postTranslatedText;
		private CEnum<scnDialogLineLanguage> _language;

		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(1)] 
		[RED("translation")] 
		public CString Translation
		{
			get => GetProperty(ref _translation);
			set => SetProperty(ref _translation, value);
		}

		[Ordinal(2)] 
		[RED("preTranslatedText")] 
		public CString PreTranslatedText
		{
			get => GetProperty(ref _preTranslatedText);
			set => SetProperty(ref _preTranslatedText, value);
		}

		[Ordinal(3)] 
		[RED("postTranslatedText")] 
		public CString PostTranslatedText
		{
			get => GetProperty(ref _postTranslatedText);
			set => SetProperty(ref _postTranslatedText, value);
		}

		[Ordinal(4)] 
		[RED("language")] 
		public CEnum<scnDialogLineLanguage> Language
		{
			get => GetProperty(ref _language);
			set => SetProperty(ref _language, value);
		}

		public scnDialogDisplayString(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
