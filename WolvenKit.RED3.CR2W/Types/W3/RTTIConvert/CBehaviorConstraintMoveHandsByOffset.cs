using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorConstraintMoveHandsByOffset : CBehaviorGraphPoseConstraintNode
	{
		[Ordinal(1)] [RED("leftHand")] 		public STwoBonesIKSolverData LeftHand { get; set;}

		[Ordinal(2)] [RED("rightHand")] 		public STwoBonesIKSolverData RightHand { get; set;}

		public CBehaviorConstraintMoveHandsByOffset(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorConstraintMoveHandsByOffset(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}