using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameQuestTypeRequestFilter : gameCustomRequestFilter
	{
		[Ordinal(0)]  [RED("includeMainQuests")] public CBool IncludeMainQuests { get; set; }
		[Ordinal(1)]  [RED("includeSideQuests")] public CBool IncludeSideQuests { get; set; }
		[Ordinal(2)]  [RED("includeStreetStories")] public CBool IncludeStreetStories { get; set; }
		[Ordinal(3)]  [RED("includeContracts")] public CBool IncludeContracts { get; set; }

		public gameQuestTypeRequestFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
