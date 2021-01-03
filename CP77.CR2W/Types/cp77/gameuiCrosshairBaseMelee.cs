using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCrosshairBaseMelee : gameuiCrosshairBaseGameController
	{
		[Ordinal(0)]  [RED("meleeStateBlackboardId")] public CUInt32 MeleeStateBlackboardId { get; set; }
		[Ordinal(1)]  [RED("playerSMBB")] public CHandle<gameIBlackboard> PlayerSMBB { get; set; }

		public gameuiCrosshairBaseMelee(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
