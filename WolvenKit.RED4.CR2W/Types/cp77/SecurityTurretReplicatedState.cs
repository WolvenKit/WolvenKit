using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityTurretReplicatedState : gameDeviceReplicatedState
	{
		[Ordinal(0)] [RED("isOn")] public CBool IsOn { get; set; }
		[Ordinal(1)] [RED("isShooting")] public CBool IsShooting { get; set; }
		[Ordinal(2)] [RED("isDead")] public CBool IsDead { get; set; }
		[Ordinal(3)] [RED("health")] public CFloat Health { get; set; }

		public SecurityTurretReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
