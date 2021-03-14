using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerVisuals_SetBrokenNoseStage : questICharacterManagerVisuals_NodeSubType
	{
		[Ordinal(0)] [RED("brokenNoseStage")] public CEnum<gameuiCharacterCustomization_BrokenNoseStage> BrokenNoseStage { get; set; }

		public questCharacterManagerVisuals_SetBrokenNoseStage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
