using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_KatanaBulletBendingEffectEntry : CVariable
	{
		[Ordinal(0)] [RED("tag")] public CName Tag { get; set; }
		[Ordinal(1)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
		[Ordinal(2)] [RED("attach")] public CBool Attach { get; set; }

		public gameEffectExecutor_KatanaBulletBendingEffectEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
