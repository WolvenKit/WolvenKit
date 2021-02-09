using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MaterialTooltipData : ATooltipData
	{
		[Ordinal(0)]  [RED("Title")] public CString Title { get; set; }
		[Ordinal(1)]  [RED("BaseMaterialQuantity")] public CInt32 BaseMaterialQuantity { get; set; }
		[Ordinal(2)]  [RED("MaterialQuantity")] public CInt32 MaterialQuantity { get; set; }
		[Ordinal(3)]  [RED("TitleLocalizationPackage")] public CHandle<gameUILocalizationDataPackage> TitleLocalizationPackage { get; set; }
		[Ordinal(4)]  [RED("DescriptionLocalizationPackage")] public CHandle<gameUILocalizationDataPackage> DescriptionLocalizationPackage { get; set; }

		public MaterialTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
