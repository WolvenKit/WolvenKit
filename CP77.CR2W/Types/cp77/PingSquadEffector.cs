using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PingSquadEffector : gameEffector
	{
		[Ordinal(0)] [RED("squadMembers")] public CArray<entEntityID> SquadMembers { get; set; }
		[Ordinal(1)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(2)] [RED("oldSquadAttitude")] public CHandle<gameAttitudeAgent> OldSquadAttitude { get; set; }
		[Ordinal(3)] [RED("quickhackLevel")] public CFloat QuickhackLevel { get; set; }
		[Ordinal(4)] [RED("data")] public CHandle<FocusForcedHighlightData> Data { get; set; }

		public PingSquadEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
