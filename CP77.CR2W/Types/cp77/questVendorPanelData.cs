using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questVendorPanelData : IScriptable
	{
		[Ordinal(0)]  [RED("assetsLibrary")] public CString AssetsLibrary { get; set; }
		[Ordinal(1)]  [RED("data")] public gameVendorData Data { get; set; }
		[Ordinal(2)]  [RED("rootItemName")] public CName RootItemName { get; set; }

		public questVendorPanelData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
