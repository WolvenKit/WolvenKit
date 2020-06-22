using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskLookat : IBehTreeTask
	{
		[RED("lookatAtStart")] 		public CBool LookatAtStart { get; set;}

		[RED("useHeadBoneRotation")] 		public CBool UseHeadBoneRotation { get; set;}

		[RED("keepLooking")] 		public CBool KeepLooking { get; set;}

		[RED("initKeeplooking")] 		public CBool InitKeeplooking { get; set;}

		[RED("verticalLookAt")] 		public CBool VerticalLookAt { get; set;}

		[RED("setAdditionalBehVar")] 		public CBool SetAdditionalBehVar { get; set;}

		[RED("keepLookingAngle")] 		public CFloat KeepLookingAngle { get; set;}

		[RED("additionalBehVarName")] 		public CName AdditionalBehVarName { get; set;}

		[RED("headBoneName")] 		public CName HeadBoneName { get; set;}

		[RED("isCombatTask")] 		public CBool IsCombatTask { get; set;}

		[RED("lookAtTargetCheck")] 		public CBool LookAtTargetCheck { get; set;}

		public BTTaskLookat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskLookat(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}