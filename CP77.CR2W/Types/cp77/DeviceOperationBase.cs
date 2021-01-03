using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DeviceOperationBase : IScriptable
	{
		[Ordinal(0)]  [RED("disableDevice")] public CBool DisableDevice { get; set; }
		[Ordinal(1)]  [RED("executeOnce")] public CBool ExecuteOnce { get; set; }
		[Ordinal(2)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(3)]  [RED("operationName")] public CName OperationName { get; set; }
		[Ordinal(4)]  [RED("toggleOperations")] public CArray<SToggleDeviceOperationData> ToggleOperations { get; set; }

		public DeviceOperationBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
