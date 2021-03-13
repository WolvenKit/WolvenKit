using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerVolumeOperations : DeviceOperations
	{
		[Ordinal(2)] [RED("triggerVolumeOperations")] public CArray<STriggerVolumeOperationData> TriggerVolumeOperations_ { get; set; }

		public TriggerVolumeOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
