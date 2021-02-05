using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageIndicatorPartLogicController : gameuiBaseDirectionalIndicatorPartLogicController
	{
		[Ordinal(0)]  [RED("maxDistanceForSharedIndicators")] public CFloat MaxDistanceForSharedIndicators { get; set; }

		public gameuiDamageIndicatorPartLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
