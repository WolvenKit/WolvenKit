using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationBrokenNoseController : gameuiICharacterCustomizationComponent
	{
		[Ordinal(0)]  [RED("stage1App")] public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance Stage1App { get; set; }
		[Ordinal(1)]  [RED("stage2App")] public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance Stage2App { get; set; }

		public gameuiCharacterCustomizationBrokenNoseController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
