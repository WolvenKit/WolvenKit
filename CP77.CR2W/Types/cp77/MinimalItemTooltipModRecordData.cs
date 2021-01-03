using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipModRecordData : MinimalItemTooltipModData
	{
		[Ordinal(0)]  [RED("dataPackage")] public CHandle<gameUILocalizationDataPackage> DataPackage { get; set; }
		[Ordinal(1)]  [RED("description")] public CString Description { get; set; }

		public MinimalItemTooltipModRecordData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
