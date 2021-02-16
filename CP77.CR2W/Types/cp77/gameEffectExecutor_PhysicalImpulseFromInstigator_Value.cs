using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_PhysicalImpulseFromInstigator_Value : gameEffectExecutor
	{
		[Ordinal(1)] [RED("magnitude")] public CFloat Magnitude { get; set; }

		public gameEffectExecutor_PhysicalImpulseFromInstigator_Value(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
