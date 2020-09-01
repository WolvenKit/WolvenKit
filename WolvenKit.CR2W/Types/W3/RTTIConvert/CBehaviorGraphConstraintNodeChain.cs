using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintNodeChain : CBehaviorGraphConstraintNode
	{
		[Ordinal(0)] [RED("("startBone")] 		public CString StartBone { get; set;}

		[Ordinal(0)] [RED("("endBone")] 		public CString EndBone { get; set;}

		[Ordinal(0)] [RED("("solverSteps")] 		public CInt32 SolverSteps { get; set;}

		[Ordinal(0)] [RED("("forwardEndBoneDir")] 		public CEnum<EAxis> ForwardEndBoneDir { get; set;}

		public CBehaviorGraphConstraintNodeChain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphConstraintNodeChain(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}