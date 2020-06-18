using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSoundAmbientAreaComponent : CSoftTriggerAreaComponent
	{
		[RED("soundEvents")] 		public StringAnsi SoundEvents { get; set;}

		[RED("reverb")] 		public SReverbDefinition Reverb { get; set;}

		[RED("customEventOnEnter")] 		public StringAnsi CustomEventOnEnter { get; set;}

		[RED("soundEventsOnEnter", 2,0)] 		public CArray<StringAnsi> SoundEventsOnEnter { get; set;}

		[RED("soundEventsOnExit", 2,0)] 		public CArray<StringAnsi> SoundEventsOnExit { get; set;}

		[RED("enterExitEventsUsePosition")] 		public CBool EnterExitEventsUsePosition { get; set;}

		[RED("intensityParameter")] 		public CFloat IntensityParameter { get; set;}

		[RED("intensityParameterFadeTime")] 		public CFloat IntensityParameterFadeTime { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("maxDistanceVertical")] 		public CFloat MaxDistanceVertical { get; set;}

		[RED("banksDependency", 2,0)] 		public CArray<CName> BanksDependency { get; set;}

		[RED("occlusionEnabled")] 		public CBool OcclusionEnabled { get; set;}

		[RED("outerListnerReverbRatio")] 		public CFloat OuterListnerReverbRatio { get; set;}

		[RED("priorityParameterMusic")] 		public CBool PriorityParameterMusic { get; set;}

		[RED("parameterEnteringTime")] 		public CFloat ParameterEnteringTime { get; set;}

		[RED("parameterEnteringCurve")] 		public CEnum<ESoundParameterCurveType> ParameterEnteringCurve { get; set;}

		[RED("parameterExitingTime")] 		public CFloat ParameterExitingTime { get; set;}

		[RED("parameterExitingCurve")] 		public CEnum<ESoundParameterCurveType> ParameterExitingCurve { get; set;}

		[RED("useListernerDistance")] 		public CBool UseListernerDistance { get; set;}

		[RED("isGate")] 		public CBool IsGate { get; set;}

		[RED("gatewayRotation")] 		public CFloat GatewayRotation { get; set;}

		[RED("isWalla")] 		public CBool IsWalla { get; set;}

		[RED("wallaSoundEvents", 2,0)] 		public CArray<StringAnsi> WallaSoundEvents { get; set;}

		[RED("wallaEmitterSpread")] 		public CFloat WallaEmitterSpread { get; set;}

		[RED("wallaOmniFactor")] 		public CFloat WallaOmniFactor { get; set;}

		[RED("wallaMinDistance")] 		public CFloat WallaMinDistance { get; set;}

		[RED("wallaMaxDistance")] 		public CFloat WallaMaxDistance { get; set;}

		[RED("wallaBoxExtention")] 		public CFloat WallaBoxExtention { get; set;}

		[RED("wallaRotation")] 		public CFloat WallaRotation { get; set;}

		[RED("wallaAfraidRetriggerTime")] 		public CFloat WallaAfraidRetriggerTime { get; set;}

		[RED("wallaAfraidDecreaseRate")] 		public CFloat WallaAfraidDecreaseRate { get; set;}

		[RED("parameters", 2,0)] 		public CArray<SSoundGameParameterValue> Parameters { get; set;}

		[RED("parameterCulling", 2,0)] 		public CArray<SSoundParameterCullSettings> ParameterCulling { get; set;}

		[RED("fitWaterShore")] 		public CBool FitWaterShore { get; set;}

		[RED("waterGridCellCount")] 		public CUInt32 WaterGridCellCount { get; set;}

		[RED("waterLevelOffset")] 		public CFloat WaterLevelOffset { get; set;}

		[RED("fitFoliage")] 		public CBool FitFoliage { get; set;}

		[RED("foliageMaxDistance")] 		public CFloat FoliageMaxDistance { get; set;}

		[RED("foliageStepNeighbors")] 		public CUInt32 FoliageStepNeighbors { get; set;}

		[RED("foliageVitalAreaRadius")] 		public CFloat FoliageVitalAreaRadius { get; set;}

		[RED("foliageVitalAreaPoints")] 		public CUInt32 FoliageVitalAreaPoints { get; set;}

		[RED("dynamicParameters", 2,0)] 		public CArray<CEnum<ESoundAmbientDynamicParameter>> DynamicParameters { get; set;}

		[RED("dynamicEvents", 2,0)] 		public CArray<SSoundAmbientDynamicSoundEvents> DynamicEvents { get; set;}

		public CSoundAmbientAreaComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSoundAmbientAreaComponent(cr2w);

	}
}