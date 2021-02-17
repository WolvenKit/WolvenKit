using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ApplyStatusEffectDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] [RED("statusEffects")] public CArray<SStatusEffectOperationData> StatusEffects { get; set; }

		public ApplyStatusEffectDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
