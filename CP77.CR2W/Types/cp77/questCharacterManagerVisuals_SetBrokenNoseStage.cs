using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerVisuals_SetBrokenNoseStage : questICharacterManagerVisuals_NodeSubType
	{
		[Ordinal(0)] [RED("brokenNoseStage")] public CEnum<gameuiCharacterCustomization_BrokenNoseStage> BrokenNoseStage { get; set; }

		public questCharacterManagerVisuals_SetBrokenNoseStage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
