using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VirtualMasterDevicePS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("owner")] public CHandle<IScriptable> Owner { get; set; }
		[Ordinal(104)] [RED("globalActions")] public CArray<CHandle<gamedeviceAction>> GlobalActions { get; set; }
		[Ordinal(105)] [RED("context")] public gameGetActionsContext Context { get; set; }
		[Ordinal(106)] [RED("connectedDevices")] public CArray<CHandle<gameDeviceComponentPS>> ConnectedDevices { get; set; }

		public VirtualMasterDevicePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
