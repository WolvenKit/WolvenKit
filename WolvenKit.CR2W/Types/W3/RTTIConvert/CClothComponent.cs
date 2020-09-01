using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CClothComponent : CMeshTypeComponent
	{
		[Ordinal(1)] [RED("resource")] 		public CHandle<CApexResource> Resource { get; set;}

		[Ordinal(2)] [RED("dispacher selection")] 		public CEnum<EDispatcherSelection> Dispacher_selection { get; set;}

		[Ordinal(3)] [RED("recomputeNormals")] 		public CBool RecomputeNormals { get; set;}

		[Ordinal(4)] [RED("correctSimulationNormals")] 		public CBool CorrectSimulationNormals { get; set;}

		[Ordinal(5)] [RED("slowStart")] 		public CBool SlowStart { get; set;}

		[Ordinal(6)] [RED("useStiffSolver")] 		public CBool UseStiffSolver { get; set;}

		[Ordinal(7)] [RED("pressure")] 		public CFloat Pressure { get; set;}

		[Ordinal(8)] [RED("lodWeights.maxDistance")] 		public CFloat LodWeights_maxDistance { get; set;}

		[Ordinal(9)] [RED("lodWeights.distanceWeight")] 		public CFloat LodWeights_distanceWeight { get; set;}

		[Ordinal(10)] [RED("lodWeights.bias")] 		public CFloat LodWeights_bias { get; set;}

		[Ordinal(11)] [RED("lodWeights.benefitsBias")] 		public CFloat LodWeights_benefitsBias { get; set;}

		[Ordinal(12)] [RED("maxDistanceBlendTime")] 		public CFloat MaxDistanceBlendTime { get; set;}

		[Ordinal(13)] [RED("uvChannelForTangentUpdate")] 		public CUInt32 UvChannelForTangentUpdate { get; set;}

		[Ordinal(14)] [RED("maxDistanceScale.Multipliable")] 		public CBool MaxDistanceScale_Multipliable { get; set;}

		[Ordinal(15)] [RED("maxDistanceScale.Scale")] 		public CFloat MaxDistanceScale_Scale { get; set;}

		[Ordinal(16)] [RED("collisionResponseCoefficient")] 		public CFloat CollisionResponseCoefficient { get; set;}

		[Ordinal(17)] [RED("allowAdaptiveTargetFrequency")] 		public CBool AllowAdaptiveTargetFrequency { get; set;}

		[Ordinal(18)] [RED("windScaler")] 		public CFloat WindScaler { get; set;}

		[Ordinal(19)] [RED("triggeringCollisionGroupNames", 2,0)] 		public CArray<CName> TriggeringCollisionGroupNames { get; set;}

		[Ordinal(20)] [RED("triggerType")] 		public CEnum<ETriggerShape> TriggerType { get; set;}

		[Ordinal(21)] [RED("triggerDimensions")] 		public Vector TriggerDimensions { get; set;}

		[Ordinal(22)] [RED("triggerLocalOffset.V[ 3 ]")] 		public Vector TriggerLocalOffset_V__3__ { get; set;}

		[Ordinal(23)] [RED("shadowDistanceOverride")] 		public CFloat ShadowDistanceOverride { get; set;}

		public CClothComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CClothComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}