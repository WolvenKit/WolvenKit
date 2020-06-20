using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphAnimatedRagdollNode : CBehaviorGraphValueNode
	{
		[RED("chanceToGoToRagdoll")] 		public CFloat ChanceToGoToRagdoll { get; set;}

		[RED("stateBlendTime")] 		public CFloat StateBlendTime { get; set;}

		[RED("maxFlightTime")] 		public Vector2 MaxFlightTime { get; set;}

		[RED("initialVelocityBoostZ")] 		public Vector2 InitialVelocityBoostZ { get; set;}

		[RED("gravity")] 		public CFloat Gravity { get; set;}

		[RED("topVerticalVelocity")] 		public CFloat TopVerticalVelocity { get; set;}

		[RED("switchAnimatedRagdollToRagdollEvent")] 		public CName SwitchAnimatedRagdollToRagdollEvent { get; set;}

		[RED("poseRotateIK")] 		public SApplyRotationIKSolverData PoseRotateIK { get; set;}

		[RED("dirIndices", 2,0)] 		public CArray<SBehaviorGraphAnimatedRagdollDirDefinition> DirIndices { get; set;}

		[RED("cachedNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedNodes { get; set;}

		public CBehaviorGraphAnimatedRagdollNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphAnimatedRagdollNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}