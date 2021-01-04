using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HasNewMountRequest : AIVehicleConditionAbstract
	{
		[Ordinal(0)]  [RED("checkOnlyInstant")] public CBool CheckOnlyInstant { get; set; }
		[Ordinal(1)]  [RED("mountRequest")] public CHandle<AIArgumentMapping> MountRequest { get; set; }

		public HasNewMountRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
