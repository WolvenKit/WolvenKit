using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ExplosiveTriggerDeviceControllerPS : ExplosiveDeviceControllerPS
	{
		[Ordinal(0)]  [RED("playerSafePass")] public CBool PlayerSafePass { get; set; }
		[Ordinal(1)]  [RED("triggerExploded")] public CBool TriggerExploded { get; set; }

		public ExplosiveTriggerDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
