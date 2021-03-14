using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphAnimatedRagdollNode : CBehaviorGraphValueNode
	{
		[Ordinal(1)] [RED("chanceToGoToRagdoll")] 		public CFloat ChanceToGoToRagdoll { get; set;}

		[Ordinal(2)] [RED("stateBlendTime")] 		public CFloat StateBlendTime { get; set;}

		[Ordinal(3)] [RED("maxFlightTime")] 		public Vector2 MaxFlightTime { get; set;}

		[Ordinal(4)] [RED("initialVelocityBoostZ")] 		public Vector2 InitialVelocityBoostZ { get; set;}

		[Ordinal(5)] [RED("gravity")] 		public CFloat Gravity { get; set;}

		[Ordinal(6)] [RED("topVerticalVelocity")] 		public CFloat TopVerticalVelocity { get; set;}

		[Ordinal(7)] [RED("switchAnimatedRagdollToRagdollEvent")] 		public CName SwitchAnimatedRagdollToRagdollEvent { get; set;}

		[Ordinal(8)] [RED("poseRotateIK")] 		public SApplyRotationIKSolverData PoseRotateIK { get; set;}

		[Ordinal(9)] [RED("dirIndices", 2,0)] 		public CArray<SBehaviorGraphAnimatedRagdollDirDefinition> DirIndices { get; set;}

		[Ordinal(10)] [RED("cachedNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedNodes { get; set;}

		public CBehaviorGraphAnimatedRagdollNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphAnimatedRagdollNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}