using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMuppetPhysicalState : CVariable
	{
		[Ordinal(0)]  [RED("groundNormal")] public Vector4 GroundNormal { get; set; }
		[Ordinal(1)]  [RED("isOnGround")] public CBool IsOnGround { get; set; }
		[Ordinal(2)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(3)]  [RED("velocity")] public Vector4 Velocity { get; set; }
		[Ordinal(4)]  [RED("worldYaw")] public CFloat WorldYaw { get; set; }

		public gameMuppetPhysicalState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
