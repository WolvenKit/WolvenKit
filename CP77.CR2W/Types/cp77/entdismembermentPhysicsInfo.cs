using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entdismembermentPhysicsInfo : CVariable
	{
		[Ordinal(0)] [RED("DensityScale")] public CFloat DensityScale { get; set; }

		public entdismembermentPhysicsInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
