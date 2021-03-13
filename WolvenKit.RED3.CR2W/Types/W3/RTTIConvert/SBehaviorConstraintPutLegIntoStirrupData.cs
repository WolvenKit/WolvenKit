using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorConstraintPutLegIntoStirrupData : CVariable
	{
		[Ordinal(1)] [RED("footStoreName")] 		public CName FootStoreName { get; set;}

		[Ordinal(2)] [RED("stirrupStoreName")] 		public CName StirrupStoreName { get; set;}

		[Ordinal(3)] [RED("stirrupFinalStoreName")] 		public CName StirrupFinalStoreName { get; set;}

		[Ordinal(4)] [RED("ik")] 		public STwoBonesIKSolverData Ik { get; set;}

		[Ordinal(5)] [RED("additionalSideDirForIKMS")] 		public Vector AdditionalSideDirForIKMS { get; set;}

		public SBehaviorConstraintPutLegIntoStirrupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorConstraintPutLegIntoStirrupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}