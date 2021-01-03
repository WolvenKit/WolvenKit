using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questVehicleCommandParams : questAICommandParams
	{
		[Ordinal(0)]  [RED("additionalParamsFollow")] public CHandle<questvehicleFollowParams> AdditionalParamsFollow { get; set; }
		[Ordinal(1)]  [RED("additionalParamsJoinTraffic")] public CHandle<questvehicleJoinTrafficParams> AdditionalParamsJoinTraffic { get; set; }
		[Ordinal(2)]  [RED("additionalParamsOnSpline")] public CHandle<questvehicleOnSplineParams> AdditionalParamsOnSpline { get; set; }
		[Ordinal(3)]  [RED("additionalParamsRacing")] public CHandle<questvehicleRacingParams> AdditionalParamsRacing { get; set; }
		[Ordinal(4)]  [RED("additionalParamsToNode")] public CHandle<questvehicleToNodeParams> AdditionalParamsToNode { get; set; }
		[Ordinal(5)]  [RED("type")] public CEnum<questVehicleCommandType> Type { get; set; }

		public questVehicleCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
