using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MaterialTooltipData : ATooltipData
	{
		[Ordinal(0)]  [RED("BaseMaterialQuantity")] public CInt32 BaseMaterialQuantity { get; set; }
		[Ordinal(1)]  [RED("DescriptionLocalizationPackage")] public CHandle<gameUILocalizationDataPackage> DescriptionLocalizationPackage { get; set; }
		[Ordinal(2)]  [RED("MaterialQuantity")] public CInt32 MaterialQuantity { get; set; }
		[Ordinal(3)]  [RED("Title")] public CString Title { get; set; }
		[Ordinal(4)]  [RED("TitleLocalizationPackage")] public CHandle<gameUILocalizationDataPackage> TitleLocalizationPackage { get; set; }

		public MaterialTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
