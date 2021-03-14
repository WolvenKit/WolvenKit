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
			get
			{
				if (_isLooped == null)
				{
					_isLooped = (CBool) CR2WTypeManager.Create("Bool", "isLooped", cr2w, this);
				}
				return _isLooped;
			}
			set
			{
				if (_isLooped == value)
				{
					return;
				}
				_isLooped = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("specificVideoForLanguage")] 
		public raRef<Bink> SpecificVideoForLanguage
		{
			get
			{
				if (_specificVideoForLanguage == null)
				{
					_specificVideoForLanguage = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "specificVideoForLanguage", cr2w, this);
				}
				return _specificVideoForLanguage;
			}
			set
			{
				if (_specificVideoForLanguage == value)
				{
					return;
				}
				_specificVideoForLanguage = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("languages")] 
		public CArray<CEnum<inkLanguageId>> Languages
		{
			get
			{
				if (_languages == null)
				{
					_languages = (CArray<CEnum<inkLanguageId>>) CR2WTypeManager.Create("array:inkLanguageId", "languages", cr2w, this);
				}
				return _languages;
			}
			set
			{
				if (_languages == value)
				{
					return;
				}
				_languages = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("fallbackVideo")] 
		public raRef<Bink> FallbackVideo
		{
			get
			{
				if (_fallbackVideo == null)
				{
					_fallbackVideo = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "fallbackVideo", cr2w, this);
				}
				return _fallbackVideo;
			}
			set
			{
				if (_fallbackVideo == value)
				{
					return;
				}
				_fallbackVideo = value;
				PropertySet(this);
			}
		}

		public inkLanguageSpecificVideoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
