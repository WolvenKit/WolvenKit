using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class KnockdownReactionTask : AIHitReactionTask
	{
		[Ordinal(4)] [RED("tweakDBPackage")] public TweakDBID TweakDBPackage { get; set; }

		public KnockdownReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
