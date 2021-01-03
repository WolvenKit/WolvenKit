using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamePhantomEntityParameters : CVariable
	{
		[Ordinal(0)]  [RED("glitchEffect")] public CName GlitchEffect { get; set; }
		[Ordinal(1)]  [RED("spawnEffect")] public CName SpawnEffect { get; set; }
		[Ordinal(2)]  [RED("teleportEndEffect")] public CName TeleportEndEffect { get; set; }
		[Ordinal(3)]  [RED("teleportStartEffect")] public CName TeleportStartEffect { get; set; }

		public gamePhantomEntityParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
