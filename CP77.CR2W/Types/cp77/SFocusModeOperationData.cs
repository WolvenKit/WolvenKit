using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SFocusModeOperationData : CVariable
	{
		[Ordinal(0)]  [RED("isLookedAt")] public CBool IsLookedAt { get; set; }
		[Ordinal(1)]  [RED("operation")] public SBaseDeviceOperationData Operation { get; set; }
		[Ordinal(2)]  [RED("operationType")] public CEnum<ETriggerOperationType> OperationType { get; set; }

		public SFocusModeOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
