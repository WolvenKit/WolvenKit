using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpExplosiveBarrel : gameDestructibleObject
	{
		[Ordinal(41)] [RED("colliderComponentName")] public CName ColliderComponentName { get; set; }
		[Ordinal(42)] [RED("destructionComponentName")] public CName DestructionComponentName { get; set; }

		public cpExplosiveBarrel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
