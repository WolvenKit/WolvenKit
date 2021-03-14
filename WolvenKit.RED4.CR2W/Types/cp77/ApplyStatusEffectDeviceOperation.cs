using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyStatusEffectDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] [RED("statusEffects")] public CArray<SStatusEffectOperationData> StatusEffects { get; set; }

		public ApplyStatusEffectDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
