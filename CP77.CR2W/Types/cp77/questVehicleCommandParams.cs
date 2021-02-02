using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questVehicleCommandParams : questAICommandParams
	{
		[Ordinal(0)]  [RED("type")] public CEnum<questVehicleCommandType> Type { get; set; }
		[Ordinal(1)]  [RED("additionalParamsOnSpline")] public CHandle<questvehicleOnSplineParams> AdditionalParamsOnSpline { get; set; }
		[Ordinal(2)]  [RED("additionalParamsFollow")] public CHandle<questvehicleFollowParams> AdditionalParamsFollow { get; set; }
		[Ordinal(3)]  [RED("additionalParamsToNode")] public CHandle<questvehicleToNodeParams> AdditionalParamsToNode { get; set; }
		[Ordinal(4)]  [RED("additionalParamsRacing")] public CHandle<questvehicleRacingParams> AdditionalParamsRacing { get; set; }
		[Ordinal(5)]  [RED("additionalParamsJoinTraffic")] public CHandle<questvehicleJoinTrafficParams> AdditionalParamsJoinTraffic { get; set; }

		public questVehicleCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
