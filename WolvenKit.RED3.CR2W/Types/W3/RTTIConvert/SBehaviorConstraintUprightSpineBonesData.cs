using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorConstraintUprightSpineBonesData : CVariable
	{
		[Ordinal(1)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(2)] [RED("weight")] 		public CFloat Weight { get; set;}

		[Ordinal(3)] [RED("boneCount")] 		public CInt32 BoneCount { get; set;}

		public SBehaviorConstraintUprightSpineBonesData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorConstraintUprightSpineBonesData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}