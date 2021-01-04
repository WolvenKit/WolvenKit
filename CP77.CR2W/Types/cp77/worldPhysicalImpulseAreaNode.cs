using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldPhysicalImpulseAreaNode : worldPhysicalTriggerAreaNode
	{
		[Ordinal(0)]  [RED("impulse")] public Vector3 Impulse { get; set; }
		[Ordinal(1)]  [RED("impulseRadius")] public CFloat ImpulseRadius { get; set; }

		public worldPhysicalImpulseAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
