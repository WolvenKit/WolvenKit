using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkCreditsResource : CResource
	{
		[Ordinal(0)]  [RED("sections")] public CArray<inkCreditsSectionEntry> Sections { get; set; }

		public inkCreditsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
