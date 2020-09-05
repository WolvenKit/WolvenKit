using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintNodeChain : CBehaviorGraphConstraintNode
	{
		[Ordinal(1)] [RED("startBone")] 		public CString StartBone { get; set;}

		[Ordinal(2)] [RED("endBone")] 		public CString EndBone { get; set;}

		[Ordinal(3)] [RED("solverSteps")] 		public CInt32 SolverSteps { get; set;}

		[Ordinal(4)] [RED("forwardEndBoneDir")] 		public CEnum<EAxis> ForwardEndBoneDir { get; set;}

		public CBehaviorGraphConstraintNodeChain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphConstraintNodeChain(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}