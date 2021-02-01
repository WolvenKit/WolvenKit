using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GravityChangeTrigger : gameObject
	{
		[Ordinal(0)]  [RED("gravityType")] public CEnum<EGravityType> GravityType { get; set; }
		[Ordinal(1)]  [RED("lowGravityStateMachineName")] public CName LowGravityStateMachineName { get; set; }
		[Ordinal(2)]  [RED("regularStateMachineName")] public CName RegularStateMachineName { get; set; }

		public GravityChangeTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
