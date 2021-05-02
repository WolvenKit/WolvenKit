using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorConstraintPutLegsIntoStirrups : CBehaviorGraphPoseConstraintNode
	{
		[Ordinal(1)] [RED("leftLeg")] 		public SBehaviorConstraintPutLegIntoStirrupData LeftLeg { get; set;}

		[Ordinal(2)] [RED("rightLeg")] 		public SBehaviorConstraintPutLegIntoStirrupData RightLeg { get; set;}

		public CBehaviorConstraintPutLegsIntoStirrups(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorConstraintPutLegsIntoStirrups(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}