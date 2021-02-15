using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitOperations : DeviceOperations
	{
		[Ordinal(2)] [RED("hitOperations")] public CArray<SHitOperationData> HitOperations_ { get; set; }

		public HitOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
