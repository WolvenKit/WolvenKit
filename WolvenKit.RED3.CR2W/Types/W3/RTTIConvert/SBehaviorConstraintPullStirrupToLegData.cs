using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorConstraintPullStirrupToLegData : CVariable
	{
		[Ordinal(1)] [RED("stirrupBoneName")] 		public CName StirrupBoneName { get; set;}

		[Ordinal(2)] [RED("stirrupContactPoint")] 		public Vector StirrupContactPoint { get; set;}

		[Ordinal(3)] [RED("footBoneName")] 		public CName FootBoneName { get; set;}

		[Ordinal(4)] [RED("footContactPoint")] 		public Vector FootContactPoint { get; set;}

		[Ordinal(5)] [RED("toeBoneName")] 		public CName ToeBoneName { get; set;}

		[Ordinal(6)] [RED("toeAlignStirrupSideDir")] 		public Vector ToeAlignStirrupSideDir { get; set;}

		[Ordinal(7)] [RED("toeAlignStirrupRotationAxisDir")] 		public Vector ToeAlignStirrupRotationAxisDir { get; set;}

		public SBehaviorConstraintPullStirrupToLegData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}