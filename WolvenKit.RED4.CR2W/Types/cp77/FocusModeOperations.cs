using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FocusModeOperations : DeviceOperations
	{
		[Ordinal(2)] [RED("focusModeOperations")] public CArray<SFocusModeOperationData> FocusModeOperations_ { get; set; }

		public FocusModeOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
