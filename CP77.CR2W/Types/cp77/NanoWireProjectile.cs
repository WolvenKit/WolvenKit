using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NanoWireProjectile : BaseProjectile
	{
		[Ordinal(51)] [RED("maxAttackRange")] public CFloat MaxAttackRange { get; set; }
		[Ordinal(52)] [RED("launchMode")] public CEnum<ELaunchMode> LaunchMode { get; set; }

		public NanoWireProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
