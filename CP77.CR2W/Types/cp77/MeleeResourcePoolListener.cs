using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MeleeResourcePoolListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] [RED("meleeCrosshair")] public wCHandle<CrosshairGameController_Melee> MeleeCrosshair { get; set; }

		public MeleeResourcePoolListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
