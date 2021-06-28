using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleCommandParams : questAICommandParams
	{
		private CEnum<questVehicleCommandType> _type;
		private CHandle<questvehicleOnSplineParams> _additionalParamsOnSpline;
		private CHandle<questvehicleFollowParams> _additionalParamsFollow;
		private CHandle<questvehicleToNodeParams> _additionalParamsToNode;
		private CHandle<questvehicleRacingParams> _additionalParamsRacing;
		private CHandle<questvehicleJoinTrafficParams> _additionalParamsJoinTraffic;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<questVehicleCommandType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("additionalParamsOnSpline")] 
		public CHandle<questvehicleOnSplineParams> AdditionalParamsOnSpline
		{
			get => GetProperty(ref _additionalParamsOnSpline);
			set => SetProperty(ref _additionalParamsOnSpline, value);
		}

		[Ordinal(2)] 
		[RED("additionalParamsFollow")] 
		public CHandle<questvehicleFollowParams> AdditionalParamsFollow
		{
			get => GetProperty(ref _additionalParamsFollow);
			set => SetProperty(ref _additionalParamsFollow, value);
		}

		[Ordinal(3)] 
		[RED("additionalParamsToNode")] 
		public CHandle<questvehicleToNodeParams> AdditionalParamsToNode
		{
			get => GetProperty(ref _additionalParamsToNode);
			set => SetProperty(ref _additionalParamsToNode, value);
		}

		[Ordinal(4)] 
		[RED("additionalParamsRacing")] 
		public CHandle<questvehicleRacingParams> AdditionalParamsRacing
		{
			get => GetProperty(ref _additionalParamsRacing);
			set => SetProperty(ref _additionalParamsRacing, value);
		}

		[Ordinal(5)] 
		[RED("additionalParamsJoinTraffic")] 
		public CHandle<questvehicleJoinTrafficParams> AdditionalParamsJoinTraffic
		{
			get => GetProperty(ref _additionalParamsJoinTraffic);
			set => SetProperty(ref _additionalParamsJoinTraffic, value);
		}

		public questVehicleCommandParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
