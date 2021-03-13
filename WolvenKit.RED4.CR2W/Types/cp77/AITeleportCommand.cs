using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITeleportCommand : AICommand
	{
		[Ordinal(4)] [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(5)] [RED("rotation")] public CFloat Rotation { get; set; }
		[Ordinal(6)] [RED("doNavTest")] public CBool DoNavTest { get; set; }

		public AITeleportCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
