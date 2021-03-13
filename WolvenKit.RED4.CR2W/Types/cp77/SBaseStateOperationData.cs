using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBaseStateOperationData : CVariable
	{
		[Ordinal(0)] [RED("state")] public CEnum<EDeviceStatus> State { get; set; }
		[Ordinal(1)] [RED("operation")] public SBaseDeviceOperationData Operation { get; set; }

		public SBaseStateOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
