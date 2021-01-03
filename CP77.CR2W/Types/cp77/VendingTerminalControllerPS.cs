using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VendingTerminalControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("VendorDataManager")] public CHandle<VendorDataManager> VendorDataManager { get; set; }
		[Ordinal(1)]  [RED("isReady")] public CBool IsReady { get; set; }
		[Ordinal(2)]  [RED("vendingTerminalSetup")] public VendingTerminalSetup VendingTerminalSetup { get; set; }

		public VendingTerminalControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
