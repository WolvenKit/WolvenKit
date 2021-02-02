using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationFeetController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(0)]  [RED("liftedFeetGroupName")] public CName LiftedFeetGroupName { get; set; }
		[Ordinal(1)]  [RED("flatFeetGroupName")] public CName FlatFeetGroupName { get; set; }

		public gameuiCharacterCustomizationFeetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
