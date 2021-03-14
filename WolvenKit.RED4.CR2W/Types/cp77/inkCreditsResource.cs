using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCreditsResource : CResource
	{
		private CArray<inkCreditsSectionEntry> _sections;

		[Ordinal(1)] 
		[RED("sections")] 
		public CArray<inkCreditsSectionEntry> Sections
		{
			get
			{
				if (_sections == null)
				{
					_sections = (CArray<inkCreditsSectionEntry>) CR2WTypeManager.Create("array:inkCreditsSectionEntry", "sections", cr2w, this);
				}
				return _sections;
			}
			set
			{
				if (_sections == value)
				{
					return;
				}
				_sections = value;
				PropertySet(this);
			}
		}

		public inkCreditsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
