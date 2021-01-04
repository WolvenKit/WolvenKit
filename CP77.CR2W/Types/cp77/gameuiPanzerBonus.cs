using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerBonus : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		[Ordinal(0)]  [RED("fallingSpeed")] public CFloat FallingSpeed { get; set; }

		public gameuiPanzerBonus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
