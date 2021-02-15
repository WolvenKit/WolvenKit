using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CacheAnimationForPotentialRagdoll : RagdollTask
	{
		[Ordinal(0)] [RED("currentBehavior")] public CName CurrentBehavior { get; set; }

		public CacheAnimationForPotentialRagdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
