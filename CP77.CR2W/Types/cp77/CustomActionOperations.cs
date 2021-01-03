using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CustomActionOperations : DeviceOperations
	{
		[Ordinal(0)]  [RED("customActions")] public SCustomDeviceActionsData CustomActions { get; set; }
		[Ordinal(1)]  [RED("customActionsOperations")] public CArray<SCustomActionOperationData> CustomActionsOperations { get; set; }

		public CustomActionOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
