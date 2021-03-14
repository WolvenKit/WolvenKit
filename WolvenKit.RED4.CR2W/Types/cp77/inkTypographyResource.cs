using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTypographyResource : CResource
	{
		private CArray<inkLanguageDefinition> _languages;

		[Ordinal(1)] 
		[RED("languages")] 
		public CArray<inkLanguageDefinition> Languages
		{
			get
			{
				if (_languages == null)
				{
					_languages = (CArray<inkLanguageDefinition>) CR2WTypeManager.Create("array:inkLanguageDefinition", "languages", cr2w, this);
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

		public inkTypographyResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
