using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SDoorStateOperationData : CVariable
	{
		[Ordinal(0)]  [RED("operation")] public SBaseDeviceOperationData Operation { get; set; }
		[Ordinal(1)]  [RED("state")] public CEnum<EDoorStatus> State { get; set; }

		public SDoorStateOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
