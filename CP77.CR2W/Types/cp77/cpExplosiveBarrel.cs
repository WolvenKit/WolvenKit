using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpExplosiveBarrel : gameDestructibleObject
	{
		[Ordinal(31)]  [RED("colliderComponentName")] public CName ColliderComponentName { get; set; }
		[Ordinal(32)]  [RED("destructionComponentName")] public CName DestructionComponentName { get; set; }

		public cpExplosiveBarrel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
