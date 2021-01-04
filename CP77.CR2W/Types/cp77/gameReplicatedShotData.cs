using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedShotData : CVariable
	{
		[Ordinal(0)]  [RED("attackId")] public TweakDBID AttackId { get; set; }
		[Ordinal(1)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(2)]  [RED("targetLocalOffset")] public Vector3 TargetLocalOffset { get; set; }
		[Ordinal(3)]  [RED("timeStamp")] public netTime TimeStamp { get; set; }

		public gameReplicatedShotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
