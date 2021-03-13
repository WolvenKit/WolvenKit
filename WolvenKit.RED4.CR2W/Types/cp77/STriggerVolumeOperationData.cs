using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class STriggerVolumeOperationData : CVariable
	{
		[Ordinal(0)] [RED("isActivatorPlayer")] public CBool IsActivatorPlayer { get; set; }
		[Ordinal(1)] [RED("isActivatorNPC")] public CBool IsActivatorNPC { get; set; }
		[Ordinal(2)] [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(3)] [RED("operationType")] public CEnum<ETriggerOperationType> OperationType { get; set; }
		[Ordinal(4)] [RED("operation")] public SBaseDeviceOperationData Operation { get; set; }

		public STriggerVolumeOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
