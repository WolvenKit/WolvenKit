using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageWithVelocity : ModifyDamageEffector
	{
		[Ordinal(2)] [RED("percentMult")] public CFloat PercentMult { get; set; }
		[Ordinal(3)] [RED("unitThreshold")] public CFloat UnitThreshold { get; set; }

		public ModifyDamageWithVelocity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
