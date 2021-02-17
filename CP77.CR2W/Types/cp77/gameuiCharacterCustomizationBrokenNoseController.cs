using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationBrokenNoseController : gameuiICharacterCustomizationComponent
	{
		[Ordinal(3)] [RED("stage1App")] public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance Stage1App { get; set; }
		[Ordinal(4)] [RED("stage2App")] public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance Stage2App { get; set; }

		public gameuiCharacterCustomizationBrokenNoseController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
