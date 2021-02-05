using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationTooltipData : MessageTooltipData
	{
		[Ordinal(0)]  [RED("Title")] public CString Title { get; set; }
		[Ordinal(1)]  [RED("Description")] public CString Description { get; set; }
		[Ordinal(2)]  [RED("TitleLocalizationPackage")] public CHandle<gameUILocalizationDataPackage> TitleLocalizationPackage { get; set; }
		[Ordinal(3)]  [RED("DescriptionLocalizationPackage")] public CHandle<gameUILocalizationDataPackage> DescriptionLocalizationPackage { get; set; }
		[Ordinal(4)]  [RED("attribiuteLevel")] public CString AttribiuteLevel { get; set; }
		[Ordinal(5)]  [RED("maxedOrMinimumLabelText")] public CString MaxedOrMinimumLabelText { get; set; }

		public CharacterCreationTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
