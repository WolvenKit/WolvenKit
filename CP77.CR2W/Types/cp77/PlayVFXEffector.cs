using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayVFXEffector : gameEffector
	{
		[Ordinal(0)] [RED("vfxName")] public CName VfxName { get; set; }
		[Ordinal(1)] [RED("startOnUninitialize")] public CBool StartOnUninitialize { get; set; }
		[Ordinal(2)] [RED("fireAndForget")] public CBool FireAndForget { get; set; }
		[Ordinal(3)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public PlayVFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
