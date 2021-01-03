using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VirtualMasterDevicePS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("connectedDevices")] public CArray<CHandle<gameDeviceComponentPS>> ConnectedDevices { get; set; }
		[Ordinal(1)]  [RED("context")] public gameGetActionsContext Context { get; set; }
		[Ordinal(2)]  [RED("globalActions")] public CArray<CHandle<gamedeviceAction>> GlobalActions { get; set; }
		[Ordinal(3)]  [RED("owner")] public CHandle<IScriptable> Owner { get; set; }

		public VirtualMasterDevicePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
