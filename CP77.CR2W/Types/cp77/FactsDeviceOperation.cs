using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FactsDeviceOperation : DeviceOperationBase
	{
		[Ordinal(0)]  [RED("facts")] public CArray<SFactOperationData> Facts { get; set; }

		public FactsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
