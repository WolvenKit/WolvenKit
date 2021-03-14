using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SInteractionAreaOperationData : CVariable
	{
		[Ordinal(0)] [RED("isActivatorPlayer")] public CBool IsActivatorPlayer { get; set; }
		[Ordinal(1)] [RED("isActivatorNPC")] public CBool IsActivatorNPC { get; set; }
		[Ordinal(2)] [RED("areaTag")] public CName AreaTag { get; set; }
		[Ordinal(3)] [RED("operationType")] public CEnum<gameinteractionsEInteractionEventType> OperationType { get; set; }
		[Ordinal(4)] [RED("operation")] public SBaseDeviceOperationData Operation { get; set; }

		public SInteractionAreaOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
