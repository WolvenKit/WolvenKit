using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FocusModeOperations : DeviceOperations
	{
		[Ordinal(0)]  [RED("focusModeOperations")] public CArray<SFocusModeOperationData> M_FocusModeOperations { get; set; }

		public FocusModeOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
