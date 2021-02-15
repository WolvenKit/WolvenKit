using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entPhysicalImpulseAreaComponent : entPhysicalTriggerComponent
	{
		[Ordinal(9)] [RED("impulse")] public Vector3 Impulse { get; set; }
		[Ordinal(10)] [RED("impulseRadius")] public CFloat ImpulseRadius { get; set; }

		public entPhysicalImpulseAreaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
