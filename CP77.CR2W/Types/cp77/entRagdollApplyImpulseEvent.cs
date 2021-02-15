using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entRagdollApplyImpulseEvent : redEvent
	{
		[Ordinal(0)] [RED("worldImpulsePos")] public Vector4 WorldImpulsePos { get; set; }
		[Ordinal(1)] [RED("worldImpulseValue")] public Vector4 WorldImpulseValue { get; set; }
		[Ordinal(2)] [RED("influenceRadius")] public CFloat InfluenceRadius { get; set; }

		public entRagdollApplyImpulseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
