using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class cpExplosiveBarrel : gameDestructibleObject
	{
		[Ordinal(0)]  [RED("colliderComponentName")] public CName ColliderComponentName { get; set; }
		[Ordinal(1)]  [RED("destructionComponentName")] public CName DestructionComponentName { get; set; }

		public cpExplosiveBarrel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
