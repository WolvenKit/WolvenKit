using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationGenitalsController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(0)]  [RED("bottomBodyGroupName")] public CName BottomBodyGroupName { get; set; }
		[Ordinal(1)]  [RED("forceHideGenitals")] public CBool ForceHideGenitals { get; set; }
		[Ordinal(2)]  [RED("upperBodyGroupName")] public CName UpperBodyGroupName { get; set; }

		public gameuiCharacterCustomizationGenitalsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
