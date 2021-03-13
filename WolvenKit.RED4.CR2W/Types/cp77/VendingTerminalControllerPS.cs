using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingTerminalControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("vendingTerminalSetup")] public VendingTerminalSetup VendingTerminalSetup { get; set; }
		[Ordinal(104)] [RED("isReady")] public CBool IsReady { get; set; }
		[Ordinal(105)] [RED("VendorDataManager")] public CHandle<VendorDataManager> VendorDataManager { get; set; }

		public VendingTerminalControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
