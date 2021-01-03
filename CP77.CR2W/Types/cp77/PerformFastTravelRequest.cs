using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PerformFastTravelRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(1)]  [RED("pointData")] public CHandle<gameFastTravelPointData> PointData { get; set; }

		public PerformFastTravelRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
