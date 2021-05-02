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
			get => GetProperty(ref _sections);
			set => SetProperty(ref _sections, value);
		}

		public inkCreditsResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
