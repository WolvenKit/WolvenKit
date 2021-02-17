using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationGenitalsController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(3)] [RED("upperBodyGroupName")] public CName UpperBodyGroupName { get; set; }
		[Ordinal(4)] [RED("bottomBodyGroupName")] public CName BottomBodyGroupName { get; set; }
		[Ordinal(5)] [RED("forceHideGenitals")] public CBool ForceHideGenitals { get; set; }

		public gameuiCharacterCustomizationGenitalsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
