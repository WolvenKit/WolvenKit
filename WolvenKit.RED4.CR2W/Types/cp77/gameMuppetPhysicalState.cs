using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetPhysicalState : CVariable
	{
		[Ordinal(0)] [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(1)] [RED("worldYaw")] public CFloat WorldYaw { get; set; }
		[Ordinal(2)] [RED("velocity")] public Vector4 Velocity { get; set; }
		[Ordinal(3)] [RED("isOnGround")] public CBool IsOnGround { get; set; }
		[Ordinal(4)] [RED("groundNormal")] public Vector4 GroundNormal { get; set; }

		public gameMuppetPhysicalState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
