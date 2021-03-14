using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkFontFamilyResource : CResource
	{
		private CName _familyName;
		private CArray<inkFontStyle> _fontStyles;

		[Ordinal(1)] 
		[RED("familyName")] 
		public CName FamilyName
		{
			get
			{
				if (_familyName == null)
				{
					_familyName = (CName) CR2WTypeManager.Create("CName", "familyName", cr2w, this);
				}
				return _familyName;
			}
			set
			{
				if (_familyName == value)
				{
					return;
				}
				_familyName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fontStyles")] 
		public CArray<inkFontStyle> FontStyles
		{
			get
			{
				if (_fontStyles == null)
				{
					_fontStyles = (CArray<inkFontStyle>) CR2WTypeManager.Create("array:inkFontStyle", "fontStyles", cr2w, this);
				}
				return _fontStyles;
			}
			set
			{
				if (_fontStyles == value)
				{
					return;
				}
				_fontStyles = value;
				PropertySet(this);
			}
		}

		public inkFontFamilyResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
