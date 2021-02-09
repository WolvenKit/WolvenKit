using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerformFastTravelRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("pointData")] public CHandle<gameFastTravelPointData> PointData { get; set; }
		[Ordinal(1)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }

		public PerformFastTravelRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
