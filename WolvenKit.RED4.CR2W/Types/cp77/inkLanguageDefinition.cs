using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLanguageDefinition : CVariable
	{
		private CName _languageCode;
		private CName _isoScriptCode;
		private CEnum<inkETextDirection> _textDirection;
		private CArray<inkLanguageFont> _fonts;

		[Ordinal(0)] 
		[RED("languageCode")] 
		public CName LanguageCode
		{
			get
			{
				if (_languageCode == null)
				{
					_languageCode = (CName) CR2WTypeManager.Create("CName", "languageCode", cr2w, this);
				}
				return _languageCode;
			}
			set
			{
				if (_languageCode == value)
				{
					return;
				}
				_languageCode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isoScriptCode")] 
		public CName IsoScriptCode
		{
			get
			{
				if (_isoScriptCode == null)
				{
					_isoScriptCode = (CName) CR2WTypeManager.Create("CName", "isoScriptCode", cr2w, this);
				}
				return _isoScriptCode;
			}
			set
			{
				if (_isoScriptCode == value)
				{
					return;
				}
				_isoScriptCode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("textDirection")] 
		public CEnum<inkETextDirection> TextDirection
		{
			get
			{
				if (_textDirection == null)
				{
					_textDirection = (CEnum<inkETextDirection>) CR2WTypeManager.Create("inkETextDirection", "textDirection", cr2w, this);
				}
				return _textDirection;
			}
			set
			{
				if (_textDirection == value)
				{
					return;
				}
				_textDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fonts")] 
		public CArray<inkLanguageFont> Fonts
		{
			get
			{
				if (_fonts == null)
				{
					_fonts = (CArray<inkLanguageFont>) CR2WTypeManager.Create("array:inkLanguageFont", "fonts", cr2w, this);
				}
				return _fonts;
			}
			set
			{
				if (_fonts == value)
				{
					return;
				}
				_fonts = value;
				PropertySet(this);
			}
		}

		public inkLanguageDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
