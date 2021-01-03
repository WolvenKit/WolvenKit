using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NanoWireProjectile : BaseProjectile
	{
		[Ordinal(0)]  [RED("launchMode")] public CEnum<ELaunchMode> LaunchMode { get; set; }
		[Ordinal(1)]  [RED("maxAttackRange")] public CFloat MaxAttackRange { get; set; }

		public NanoWireProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
