using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CClothComponent : CMeshTypeComponent
	{
		[RED("resource")] 		public CHandle<CApexResource> Resource { get; set;}

		[RED("dispacher selection")] 		public CEnum<EDispatcherSelection> Dispacher_selection { get; set;}

		[RED("recomputeNormals")] 		public CBool RecomputeNormals { get; set;}

		[RED("correctSimulationNormals")] 		public CBool CorrectSimulationNormals { get; set;}

		[RED("slowStart")] 		public CBool SlowStart { get; set;}

		[RED("useStiffSolver")] 		public CBool UseStiffSolver { get; set;}

		[RED("pressure")] 		public CFloat Pressure { get; set;}

		[RED("lodWeights.maxDistance")] 		public CFloat LodWeights_maxDistance { get; set;}

		[RED("lodWeights.distanceWeight")] 		public CFloat LodWeights_distanceWeight { get; set;}

		[RED("lodWeights.bias")] 		public CFloat LodWeights_bias { get; set;}

		[RED("lodWeights.benefitsBias")] 		public CFloat LodWeights_benefitsBias { get; set;}

		[RED("maxDistanceBlendTime")] 		public CFloat MaxDistanceBlendTime { get; set;}

		[RED("uvChannelForTangentUpdate")] 		public CUInt32 UvChannelForTangentUpdate { get; set;}

		[RED("maxDistanceScale.Multipliable")] 		public CBool MaxDistanceScale_Multipliable { get; set;}

		[RED("maxDistanceScale.Scale")] 		public CFloat MaxDistanceScale_Scale { get; set;}

		[RED("collisionResponseCoefficient")] 		public CFloat CollisionResponseCoefficient { get; set;}

		[RED("allowAdaptiveTargetFrequency")] 		public CBool AllowAdaptiveTargetFrequency { get; set;}

		[RED("windScaler")] 		public CFloat WindScaler { get; set;}

		[RED("triggeringCollisionGroupNames", 2,0)] 		public CArray<CName> TriggeringCollisionGroupNames { get; set;}

		[RED("triggerType")] 		public CEnum<ETriggerShape> TriggerType { get; set;}

		[RED("triggerDimensions")] 		public Vector TriggerDimensions { get; set;}

		[RED("triggerLocalOffset.V[ 3 ]")] 		public Vector TriggerLocalOffset_V__3__ { get; set;}

		[RED("shadowDistanceOverride")] 		public CFloat ShadowDistanceOverride { get; set;}

		public CClothComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CClothComponent(cr2w);

	}
}