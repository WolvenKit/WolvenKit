using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GrenadeQuickhackKillEntry : CVariable
	{
		[Ordinal(0)] [RED("source")] public wCHandle<gameObject> Source { get; set; }
		[Ordinal(1)] [RED("targets")] public CArray<wCHandle<gameObject>> Targets { get; set; }
		[Ordinal(2)] [RED("timestamps")] public CArray<CFloat> Timestamps { get; set; }

		public GrenadeQuickhackKillEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
