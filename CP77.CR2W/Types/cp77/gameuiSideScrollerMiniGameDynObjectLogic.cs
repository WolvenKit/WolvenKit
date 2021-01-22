using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameDynObjectLogic : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("spawnPoolSize")] public CUInt32 SpawnPoolSize { get; set; }

		public gameuiSideScrollerMiniGameDynObjectLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
