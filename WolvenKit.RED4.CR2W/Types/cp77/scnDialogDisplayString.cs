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
			get
			{
				if (_text == null)
				{
					_text = (CString) CR2WTypeManager.Create("String", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("translation")] 
		public CString Translation
		{
			get
			{
				if (_translation == null)
				{
					_translation = (CString) CR2WTypeManager.Create("String", "translation", cr2w, this);
				}
				return _translation;
			}
			set
			{
				if (_translation == value)
				{
					return;
				}
				_translation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("preTranslatedText")] 
		public CString PreTranslatedText
		{
			get
			{
				if (_preTranslatedText == null)
				{
					_preTranslatedText = (CString) CR2WTypeManager.Create("String", "preTranslatedText", cr2w, this);
				}
				return _preTranslatedText;
			}
			set
			{
				if (_preTranslatedText == value)
				{
					return;
				}
				_preTranslatedText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("postTranslatedText")] 
		public CString PostTranslatedText
		{
			get
			{
				if (_postTranslatedText == null)
				{
					_postTranslatedText = (CString) CR2WTypeManager.Create("String", "postTranslatedText", cr2w, this);
				}
				return _postTranslatedText;
			}
			set
			{
				if (_postTranslatedText == value)
				{
					return;
				}
				_postTranslatedText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("language")] 
		public CEnum<scnDialogLineLanguage> Language
		{
			get
			{
				if (_language == null)
				{
					_language = (CEnum<scnDialogLineLanguage>) CR2WTypeManager.Create("scnDialogLineLanguage", "language", cr2w, this);
				}
				return _language;
			}
			set
			{
				if (_language == value)
				{
					return;
				}
				_language = value;
				PropertySet(this);
			}
		}

		public scnDialogDisplayString(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
