using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationFeetController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(3)] [RED("liftedFeetGroupName")] public CName LiftedFeetGroupName { get; set; }
		[Ordinal(4)] [RED("flatFeetGroupName")] public CName FlatFeetGroupName { get; set; }

		public gameuiCharacterCustomizationFeetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
