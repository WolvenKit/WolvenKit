using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameQuestTypeRequestFilter : gameCustomRequestFilter
	{
		[Ordinal(0)]  [RED("includeContracts")] public CBool IncludeContracts { get; set; }
		[Ordinal(1)]  [RED("includeMainQuests")] public CBool IncludeMainQuests { get; set; }
		[Ordinal(2)]  [RED("includeSideQuests")] public CBool IncludeSideQuests { get; set; }
		[Ordinal(3)]  [RED("includeStreetStories")] public CBool IncludeStreetStories { get; set; }

		public gameQuestTypeRequestFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
