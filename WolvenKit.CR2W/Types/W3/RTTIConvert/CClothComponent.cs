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
		[Ordinal(0)] [RED("resource")] 		public CHandle<CApexResource> Resource { get; set;}

		[Ordinal(0)] [RED("dispacher selection")] 		public CEnum<EDispatcherSelection> Dispacher_selection { get; set;}

		[Ordinal(0)] [RED("recomputeNormals")] 		public CBool RecomputeNormals { get; set;}

		[Ordinal(0)] [RED("correctSimulationNormals")] 		public CBool CorrectSimulationNormals { get; set;}

		[Ordinal(0)] [RED("slowStart")] 		public CBool SlowStart { get; set;}

		[Ordinal(0)] [RED("useStiffSolver")] 		public CBool UseStiffSolver { get; set;}

		[Ordinal(0)] [RED("pressure")] 		public CFloat Pressure { get; set;}

		[Ordinal(0)] [RED("lodWeights.maxDistance")] 		public CFloat LodWeights_maxDistance { get; set;}

		[Ordinal(0)] [RED("lodWeights.distanceWeight")] 		public CFloat LodWeights_distanceWeight { get; set;}

		[Ordinal(0)] [RED("lodWeights.bias")] 		public CFloat LodWeights_bias { get; set;}

		[Ordinal(0)] [RED("lodWeights.benefitsBias")] 		public CFloat LodWeights_benefitsBias { get; set;}

		[Ordinal(0)] [RED("maxDistanceBlendTime")] 		public CFloat MaxDistanceBlendTime { get; set;}

		[Ordinal(0)] [RED("uvChannelForTangentUpdate")] 		public CUInt32 UvChannelForTangentUpdate { get; set;}

		[Ordinal(0)] [RED("maxDistanceScale.Multipliable")] 		public CBool MaxDistanceScale_Multipliable { get; set;}

		[Ordinal(0)] [RED("maxDistanceScale.Scale")] 		public CFloat MaxDistanceScale_Scale { get; set;}

		[Ordinal(0)] [RED("collisionResponseCoefficient")] 		public CFloat CollisionResponseCoefficient { get; set;}

		[Ordinal(0)] [RED("allowAdaptiveTargetFrequency")] 		public CBool AllowAdaptiveTargetFrequency { get; set;}

		[Ordinal(0)] [RED("windScaler")] 		public CFloat WindScaler { get; set;}

		[Ordinal(0)] [RED("triggeringCollisionGroupNames", 2,0)] 		public CArray<CName> TriggeringCollisionGroupNames { get; set;}

		[Ordinal(0)] [RED("triggerType")] 		public CEnum<ETriggerShape> TriggerType { get; set;}

		[Ordinal(0)] [RED("triggerDimensions")] 		public Vector TriggerDimensions { get; set;}

		[Ordinal(0)] [RED("triggerLocalOffset.V[ 3 ]")] 		public Vector TriggerLocalOffset_V__3__ { get; set;}

		[Ordinal(0)] [RED("shadowDistanceOverride")] 		public CFloat ShadowDistanceOverride { get; set;}

		public CClothComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CClothComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}