using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VendingMachine : InteractiveDevice
	{
		[Ordinal(0)]  [RED("advUiComponent")] public CHandle<entIComponent> AdvUiComponent { get; set; }
		[Ordinal(1)]  [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(2)]  [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }
		[Ordinal(3)]  [RED("vendorID")] public CHandle<VendorComponent> VendorID { get; set; }

		public VendingMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
