using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ApplyDamageDeviceOperation : DeviceOperationBase
	{
		[Ordinal(0)]  [RED("damages")] public CArray<SDamageOperationData> Damages { get; set; }

		public ApplyDamageDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
