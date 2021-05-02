using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSoundAmbientAreaComponent : CSoftTriggerAreaComponent
	{
		[Ordinal(1)] [RED("soundEvents")] 		public StringAnsi SoundEvents { get; set;}

		[Ordinal(2)] [RED("reverb")] 		public SReverbDefinition Reverb { get; set;}

		[Ordinal(3)] [RED("customEventOnEnter")] 		public StringAnsi CustomEventOnEnter { get; set;}

		[Ordinal(4)] [RED("soundEventsOnEnter", 2,0)] 		public CArray<StringAnsi> SoundEventsOnEnter { get; set;}

		[Ordinal(5)] [RED("soundEventsOnExit", 2,0)] 		public CArray<StringAnsi> SoundEventsOnExit { get; set;}

		[Ordinal(6)] [RED("enterExitEventsUsePosition")] 		public CBool EnterExitEventsUsePosition { get; set;}

		[Ordinal(7)] [RED("intensityParameter")] 		public CFloat IntensityParameter { get; set;}

		[Ordinal(8)] [RED("intensityParameterFadeTime")] 		public CFloat IntensityParameterFadeTime { get; set;}

		[Ordinal(9)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(10)] [RED("maxDistanceVertical")] 		public CFloat MaxDistanceVertical { get; set;}

		[Ordinal(11)] [RED("banksDependency", 2,0)] 		public CArray<CName> BanksDependency { get; set;}

		[Ordinal(12)] [RED("occlusionEnabled")] 		public CBool OcclusionEnabled { get; set;}

		[Ordinal(13)] [RED("outerListnerReverbRatio")] 		public CFloat OuterListnerReverbRatio { get; set;}

		[Ordinal(14)] [RED("priorityParameterMusic")] 		public CBool PriorityParameterMusic { get; set;}

		[Ordinal(15)] [RED("parameterEnteringTime")] 		public CFloat ParameterEnteringTime { get; set;}

		[Ordinal(16)] [RED("parameterEnteringCurve")] 		public CEnum<ESoundParameterCurveType> ParameterEnteringCurve { get; set;}

		[Ordinal(17)] [RED("parameterExitingTime")] 		public CFloat ParameterExitingTime { get; set;}

		[Ordinal(18)] [RED("parameterExitingCurve")] 		public CEnum<ESoundParameterCurveType> ParameterExitingCurve { get; set;}

		[Ordinal(19)] [RED("useListernerDistance")] 		public CBool UseListernerDistance { get; set;}

		[Ordinal(20)] [RED("isGate")] 		public CBool IsGate { get; set;}

		[Ordinal(21)] [RED("gatewayRotation")] 		public CFloat GatewayRotation { get; set;}

		[Ordinal(22)] [RED("isWalla")] 		public CBool IsWalla { get; set;}

		[Ordinal(23)] [RED("wallaSoundEvents", 2,0)] 		public CArray<StringAnsi> WallaSoundEvents { get; set;}

		[Ordinal(24)] [RED("wallaEmitterSpread")] 		public CFloat WallaEmitterSpread { get; set;}

		[Ordinal(25)] [RED("wallaOmniFactor")] 		public CFloat WallaOmniFactor { get; set;}

		[Ordinal(26)] [RED("wallaMinDistance")] 		public CFloat WallaMinDistance { get; set;}

		[Ordinal(27)] [RED("wallaMaxDistance")] 		public CFloat WallaMaxDistance { get; set;}

		[Ordinal(28)] [RED("wallaBoxExtention")] 		public CFloat WallaBoxExtention { get; set;}

		[Ordinal(29)] [RED("wallaRotation")] 		public CFloat WallaRotation { get; set;}

		[Ordinal(30)] [RED("wallaAfraidRetriggerTime")] 		public CFloat WallaAfraidRetriggerTime { get; set;}

		[Ordinal(31)] [RED("wallaAfraidDecreaseRate")] 		public CFloat WallaAfraidDecreaseRate { get; set;}

		[Ordinal(32)] [RED("parameters", 2,0)] 		public CArray<SSoundGameParameterValue> Parameters { get; set;}

		[Ordinal(33)] [RED("parameterCulling", 2,0)] 		public CArray<SSoundParameterCullSettings> ParameterCulling { get; set;}

		[Ordinal(34)] [RED("fitWaterShore")] 		public CBool FitWaterShore { get; set;}

		[Ordinal(35)] [RED("waterGridCellCount")] 		public CUInt32 WaterGridCellCount { get; set;}

		[Ordinal(36)] [RED("waterLevelOffset")] 		public CFloat WaterLevelOffset { get; set;}

		[Ordinal(37)] [RED("fitFoliage")] 		public CBool FitFoliage { get; set;}

		[Ordinal(38)] [RED("foliageMaxDistance")] 		public CFloat FoliageMaxDistance { get; set;}

		[Ordinal(39)] [RED("foliageStepNeighbors")] 		public CUInt32 FoliageStepNeighbors { get; set;}

		[Ordinal(40)] [RED("foliageVitalAreaRadius")] 		public CFloat FoliageVitalAreaRadius { get; set;}

		[Ordinal(41)] [RED("foliageVitalAreaPoints")] 		public CUInt32 FoliageVitalAreaPoints { get; set;}

		[Ordinal(42)] [RED("dynamicParameters", 2,0)] 		public CArray<CEnum<ESoundAmbientDynamicParameter>> DynamicParameters { get; set;}

		[Ordinal(43)] [RED("dynamicEvents", 2,0)] 		public CArray<SSoundAmbientDynamicSoundEvents> DynamicEvents { get; set;}

		public CSoundAmbientAreaComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}