using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] [RED("isAttackerPlayer")] public CBool IsAttackerPlayer { get; set; }
		[Ordinal(2)] [RED("isAttackerNPC")] public CBool IsAttackerNPC { get; set; }
		[Ordinal(3)] [RED("bullets")] public CBool Bullets { get; set; }
		[Ordinal(4)] [RED("explosions")] public CBool Explosions { get; set; }
		[Ordinal(5)] [RED("melee")] public CBool Melee { get; set; }
		[Ordinal(6)] [RED("healthPercentage")] public CFloat HealthPercentage { get; set; }

		public HitOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
