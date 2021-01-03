using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationPersonalLinkController : gameuiICharacterCustomizationComponent
	{
		[Ordinal(0)]  [RED("simpleLinkGroup")] public CName SimpleLinkGroup { get; set; }

		public gameuiCharacterCustomizationPersonalLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
