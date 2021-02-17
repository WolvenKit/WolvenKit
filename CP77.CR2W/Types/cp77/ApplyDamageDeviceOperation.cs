using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ApplyDamageDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] [RED("damages")] public CArray<SDamageOperationData> Damages { get; set; }

		public ApplyDamageDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
