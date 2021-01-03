using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameScanningTooltipElementData : CVariable
	{
		[Ordinal(0)]  [RED("localizedDescription")] public CName LocalizedDescription { get; set; }
		[Ordinal(1)]  [RED("localizedName")] public CName LocalizedName { get; set; }
		[Ordinal(2)]  [RED("recordID")] public TweakDBID RecordID { get; set; }

		public gameScanningTooltipElementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
