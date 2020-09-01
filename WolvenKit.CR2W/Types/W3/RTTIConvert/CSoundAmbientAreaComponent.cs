using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSoundAmbientAreaComponent : CSoftTriggerAreaComponent
	{
		[Ordinal(0)] [RED("soundEvents")] 		public StringAnsi SoundEvents { get; set;}

		[Ordinal(0)] [RED("reverb")] 		public SReverbDefinition Reverb { get; set;}

		[Ordinal(0)] [RED("customEventOnEnter")] 		public StringAnsi CustomEventOnEnter { get; set;}

		[Ordinal(0)] [RED("soundEventsOnEnter", 2,0)] 		public CArray<StringAnsi> SoundEventsOnEnter { get; set;}

		[Ordinal(0)] [RED("soundEventsOnExit", 2,0)] 		public CArray<StringAnsi> SoundEventsOnExit { get; set;}

		[Ordinal(0)] [RED("enterExitEventsUsePosition")] 		public CBool EnterExitEventsUsePosition { get; set;}

		[Ordinal(0)] [RED("intensityParameter")] 		public CFloat IntensityParameter { get; set;}

		[Ordinal(0)] [RED("intensityParameterFadeTime")] 		public CFloat IntensityParameterFadeTime { get; set;}

		[Ordinal(0)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(0)] [RED("maxDistanceVertical")] 		public CFloat MaxDistanceVertical { get; set;}

		[Ordinal(0)] [RED("banksDependency", 2,0)] 		public CArray<CName> BanksDependency { get; set;}

		[Ordinal(0)] [RED("occlusionEnabled")] 		public CBool OcclusionEnabled { get; set;}

		[Ordinal(0)] [RED("outerListnerReverbRatio")] 		public CFloat OuterListnerReverbRatio { get; set;}

		[Ordinal(0)] [RED("priorityParameterMusic")] 		public CBool PriorityParameterMusic { get; set;}

		[Ordinal(0)] [RED("parameterEnteringTime")] 		public CFloat ParameterEnteringTime { get; set;}

		[Ordinal(0)] [RED("parameterEnteringCurve")] 		public CEnum<ESoundParameterCurveType> ParameterEnteringCurve { get; set;}

		[Ordinal(0)] [RED("parameterExitingTime")] 		public CFloat ParameterExitingTime { get; set;}

		[Ordinal(0)] [RED("parameterExitingCurve")] 		public CEnum<ESoundParameterCurveType> ParameterExitingCurve { get; set;}

		[Ordinal(0)] [RED("useListernerDistance")] 		public CBool UseListernerDistance { get; set;}

		[Ordinal(0)] [RED("isGate")] 		public CBool IsGate { get; set;}

		[Ordinal(0)] [RED("gatewayRotation")] 		public CFloat GatewayRotation { get; set;}

		[Ordinal(0)] [RED("isWalla")] 		public CBool IsWalla { get; set;}

		[Ordinal(0)] [RED("wallaSoundEvents", 2,0)] 		public CArray<StringAnsi> WallaSoundEvents { get; set;}

		[Ordinal(0)] [RED("wallaEmitterSpread")] 		public CFloat WallaEmitterSpread { get; set;}

		[Ordinal(0)] [RED("wallaOmniFactor")] 		public CFloat WallaOmniFactor { get; set;}

		[Ordinal(0)] [RED("wallaMinDistance")] 		public CFloat WallaMinDistance { get; set;}

		[Ordinal(0)] [RED("wallaMaxDistance")] 		public CFloat WallaMaxDistance { get; set;}

		[Ordinal(0)] [RED("wallaBoxExtention")] 		public CFloat WallaBoxExtention { get; set;}

		[Ordinal(0)] [RED("wallaRotation")] 		public CFloat WallaRotation { get; set;}

		[Ordinal(0)] [RED("wallaAfraidRetriggerTime")] 		public CFloat WallaAfraidRetriggerTime { get; set;}

		[Ordinal(0)] [RED("wallaAfraidDecreaseRate")] 		public CFloat WallaAfraidDecreaseRate { get; set;}

		[Ordinal(0)] [RED("parameters", 2,0)] 		public CArray<SSoundGameParameterValue> Parameters { get; set;}

		[Ordinal(0)] [RED("parameterCulling", 2,0)] 		public CArray<SSoundParameterCullSettings> ParameterCulling { get; set;}

		[Ordinal(0)] [RED("fitWaterShore")] 		public CBool FitWaterShore { get; set;}

		[Ordinal(0)] [RED("waterGridCellCount")] 		public CUInt32 WaterGridCellCount { get; set;}

		[Ordinal(0)] [RED("waterLevelOffset")] 		public CFloat WaterLevelOffset { get; set;}

		[Ordinal(0)] [RED("fitFoliage")] 		public CBool FitFoliage { get; set;}

		[Ordinal(0)] [RED("foliageMaxDistance")] 		public CFloat FoliageMaxDistance { get; set;}

		[Ordinal(0)] [RED("foliageStepNeighbors")] 		public CUInt32 FoliageStepNeighbors { get; set;}

		[Ordinal(0)] [RED("foliageVitalAreaRadius")] 		public CFloat FoliageVitalAreaRadius { get; set;}

		[Ordinal(0)] [RED("foliageVitalAreaPoints")] 		public CUInt32 FoliageVitalAreaPoints { get; set;}

		[Ordinal(0)] [RED("dynamicParameters", 2,0)] 		public CArray<CEnum<ESoundAmbientDynamicParameter>> DynamicParameters { get; set;}

		[Ordinal(0)] [RED("dynamicEvents", 2,0)] 		public CArray<SSoundAmbientDynamicSoundEvents> DynamicEvents { get; set;}

		public CSoundAmbientAreaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSoundAmbientAreaComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}