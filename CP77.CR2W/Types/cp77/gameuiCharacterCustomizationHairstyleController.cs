using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationHairstyleController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(0)]  [RED("headGroupName")] public CName HeadGroupName { get; set; }

		public gameuiCharacterCustomizationHairstyleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
