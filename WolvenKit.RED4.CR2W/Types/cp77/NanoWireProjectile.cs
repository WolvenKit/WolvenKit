using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NanoWireProjectile : BaseProjectile
	{
		[Ordinal(51)] [RED("maxAttackRange")] public CFloat MaxAttackRange { get; set; }
		[Ordinal(52)] [RED("launchMode")] public CEnum<ELaunchMode> LaunchMode { get; set; }

		public NanoWireProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
