using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedShotData : CVariable
	{
		[Ordinal(0)] [RED("timeStamp")] public netTime TimeStamp { get; set; }
		[Ordinal(1)] [RED("attackId")] public TweakDBID AttackId { get; set; }
		[Ordinal(2)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(3)] [RED("targetLocalOffset")] public Vector3 TargetLocalOffset { get; set; }

		public gameReplicatedShotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
