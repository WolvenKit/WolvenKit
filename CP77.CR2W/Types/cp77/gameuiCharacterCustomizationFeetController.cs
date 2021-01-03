using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationFeetController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(0)]  [RED("flatFeetGroupName")] public CName FlatFeetGroupName { get; set; }
		[Ordinal(1)]  [RED("liftedFeetGroupName")] public CName LiftedFeetGroupName { get; set; }

		public gameuiCharacterCustomizationFeetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
