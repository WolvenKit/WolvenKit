using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityTurretReplicatedState : gameDeviceReplicatedState
	{
		[Ordinal(0)]  [RED("health")] public CFloat Health { get; set; }
		[Ordinal(1)]  [RED("isDead")] public CBool IsDead { get; set; }
		[Ordinal(2)]  [RED("isOn")] public CBool IsOn { get; set; }
		[Ordinal(3)]  [RED("isShooting")] public CBool IsShooting { get; set; }

		public SecurityTurretReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
