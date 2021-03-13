using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SHitOperationData : CVariable
	{
		[Ordinal(0)] [RED("isAttackerPlayer")] public CBool IsAttackerPlayer { get; set; }
		[Ordinal(1)] [RED("isAttackerNPC")] public CBool IsAttackerNPC { get; set; }
		[Ordinal(2)] [RED("bullets")] public CBool Bullets { get; set; }
		[Ordinal(3)] [RED("explosions")] public CBool Explosions { get; set; }
		[Ordinal(4)] [RED("melee")] public CBool Melee { get; set; }
		[Ordinal(5)] [RED("healthPercentage")] public CFloat HealthPercentage { get; set; }
		[Ordinal(6)] [RED("operation")] public SBaseDeviceOperationData Operation { get; set; }

		public SHitOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
