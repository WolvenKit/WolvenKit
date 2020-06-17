using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintNodeChain : CBehaviorGraphConstraintNode
	{
		[RED("startBone")] 		public CString StartBone { get; set;}

		[RED("endBone")] 		public CString EndBone { get; set;}

		[RED("solverSteps")] 		public CInt32 SolverSteps { get; set;}

		[RED("forwardEndBoneDir")] 		public EAxis ForwardEndBoneDir { get; set;}

		public CBehaviorGraphConstraintNodeChain(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphConstraintNodeChain(cr2w);

	}
}