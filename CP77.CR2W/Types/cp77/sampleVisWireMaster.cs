using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class sampleVisWireMaster : gameObject
	{
		[Ordinal(0)]  [RED("dependableEntities")] public CArray<NodeRef> DependableEntities { get; set; }
		[Ordinal(1)]  [RED("found")] public CBool Found { get; set; }
		[Ordinal(2)]  [RED("inFocus")] public CBool InFocus { get; set; }
		[Ordinal(3)]  [RED("lookedAt")] public CBool LookedAt { get; set; }

		public sampleVisWireMaster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
