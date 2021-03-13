using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerformFastTravelRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("pointData")] public CHandle<gameFastTravelPointData> PointData { get; set; }
		[Ordinal(1)] [RED("player")] public wCHandle<gameObject> Player { get; set; }

		public PerformFastTravelRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
