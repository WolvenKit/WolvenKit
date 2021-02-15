using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiBinkResource : CVariable
	{
		[Ordinal(0)] [RED("video")] public raRef<Bink> Video { get; set; }

		public gameuiBinkResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
