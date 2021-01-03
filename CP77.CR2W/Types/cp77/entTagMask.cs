using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entTagMask : CVariable
	{
		[Ordinal(0)]  [RED("excludedTags")] public redTagList ExcludedTags { get; set; }
		[Ordinal(1)]  [RED("hardTags")] public redTagList HardTags { get; set; }
		[Ordinal(2)]  [RED("softTags")] public redTagList SoftTags { get; set; }

		public entTagMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
