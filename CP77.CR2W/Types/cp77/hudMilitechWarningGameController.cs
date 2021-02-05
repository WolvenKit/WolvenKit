using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hudMilitechWarningGameController : gameuiHUDGameController
	{
		[Ordinal(7)]  [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(8)]  [RED("anim")] public CHandle<inkanimProxy> Anim { get; set; }
		[Ordinal(9)]  [RED("factListenerId")] public CUInt32 FactListenerId { get; set; }

		public hudMilitechWarningGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
