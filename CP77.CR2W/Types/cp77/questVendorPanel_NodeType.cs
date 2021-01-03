using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questVendorPanel_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("assetsLibrary")] public CString AssetsLibrary { get; set; }
		[Ordinal(1)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(2)]  [RED("openVendorPanel")] public CBool OpenVendorPanel { get; set; }
		[Ordinal(3)]  [RED("rootItemName")] public CName RootItemName { get; set; }
		[Ordinal(4)]  [RED("scenarioName")] public CName ScenarioName { get; set; }
		[Ordinal(5)]  [RED("vendorId")] public CString VendorId { get; set; }

		public questVendorPanel_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
