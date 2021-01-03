using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiKillInfo : CVariable
	{
		[Ordinal(0)]  [RED("killType")] public CEnum<gameKillType> KillType { get; set; }
		[Ordinal(1)]  [RED("killerEntity")] public wCHandle<gameObject> KillerEntity { get; set; }
		[Ordinal(2)]  [RED("victimEntity")] public wCHandle<gameObject> VictimEntity { get; set; }

		public gameuiKillInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
