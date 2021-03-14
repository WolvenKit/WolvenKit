using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLanguageFont : CVariable
	{
		private raRef<inkFontFamilyResource> _font;
		private CHandle<inkLanguageFontMapper> _mapper;

		[Ordinal(0)] 
		[RED("font")] 
		public raRef<inkFontFamilyResource> Font
		{
			get
			{
				if (_font == null)
				{
					_font = (raRef<inkFontFamilyResource>) CR2WTypeManager.Create("raRef:inkFontFamilyResource", "font", cr2w, this);
				}
				return _font;
			}
			set
			{
				if (_font == value)
				{
					return;
				}
				_font = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mapper")] 
		public CHandle<inkLanguageFontMapper> Mapper
		{
			get
			{
				if (_mapper == null)
				{
					_mapper = (CHandle<inkLanguageFontMapper>) CR2WTypeManager.Create("handle:inkLanguageFontMapper", "mapper", cr2w, this);
				}
				return _mapper;
			}
			set
			{
				if (_mapper == value)
				{
					return;
				}
				_mapper = value;
				PropertySet(this);
			}
		}

		public inkLanguageFont(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
