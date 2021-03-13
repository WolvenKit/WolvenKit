using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveTriggerDeviceControllerPS : ExplosiveDeviceControllerPS
	{
		[Ordinal(119)] [RED("playerSafePass")] public CBool PlayerSafePass { get; set; }
		[Ordinal(120)] [RED("triggerExploded")] public CBool TriggerExploded { get; set; }

		public ExplosiveTriggerDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
