using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskLookat : IBehTreeTask
	{
		[Ordinal(1)] [RED("lookatAtStart")] 		public CBool LookatAtStart { get; set;}

		[Ordinal(2)] [RED("useHeadBoneRotation")] 		public CBool UseHeadBoneRotation { get; set;}

		[Ordinal(3)] [RED("keepLooking")] 		public CBool KeepLooking { get; set;}

		[Ordinal(4)] [RED("initKeeplooking")] 		public CBool InitKeeplooking { get; set;}

		[Ordinal(5)] [RED("verticalLookAt")] 		public CBool VerticalLookAt { get; set;}

		[Ordinal(6)] [RED("setAdditionalBehVar")] 		public CBool SetAdditionalBehVar { get; set;}

		[Ordinal(7)] [RED("keepLookingAngle")] 		public CFloat KeepLookingAngle { get; set;}

		[Ordinal(8)] [RED("additionalBehVarName")] 		public CName AdditionalBehVarName { get; set;}

		[Ordinal(9)] [RED("headBoneName")] 		public CName HeadBoneName { get; set;}

		[Ordinal(10)] [RED("isCombatTask")] 		public CBool IsCombatTask { get; set;}

		[Ordinal(11)] [RED("lookAtTargetCheck")] 		public CBool LookAtTargetCheck { get; set;}

		public BTTaskLookat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskLookat(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}