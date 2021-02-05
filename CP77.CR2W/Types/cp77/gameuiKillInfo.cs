using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiKillInfo : CVariable
	{
		[Ordinal(0)]  [RED("killerEntity")] public wCHandle<gameObject> KillerEntity { get; set; }
		[Ordinal(1)]  [RED("victimEntity")] public wCHandle<gameObject> VictimEntity { get; set; }
		[Ordinal(2)]  [RED("killType")] public CEnum<gameKillType> KillType { get; set; }

		public gameuiKillInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
