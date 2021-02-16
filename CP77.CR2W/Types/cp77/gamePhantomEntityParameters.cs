using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePhantomEntityParameters : CVariable
	{
		[Ordinal(0)] [RED("teleportStartEffect")] public CName TeleportStartEffect { get; set; }
		[Ordinal(1)] [RED("teleportEndEffect")] public CName TeleportEndEffect { get; set; }
		[Ordinal(2)] [RED("spawnEffect")] public CName SpawnEffect { get; set; }
		[Ordinal(3)] [RED("glitchEffect")] public CName GlitchEffect { get; set; }

		public gamePhantomEntityParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
