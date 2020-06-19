using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskLookatDef : IBehTreeTaskDefinition
	{
		[RED("lookatAtStart")] 		public CBool LookatAtStart { get; set;}

		[RED("headBoneName")] 		public CName HeadBoneName { get; set;}

		[RED("useHeadBoneRotation")] 		public CBool UseHeadBoneRotation { get; set;}

		[RED("keepLooking")] 		public CBool KeepLooking { get; set;}

		[RED("verticalLookAt")] 		public CBool VerticalLookAt { get; set;}

		[RED("setAdditionalBehVar")] 		public CBool SetAdditionalBehVar { get; set;}

		[RED("additionalBehVarName")] 		public CName AdditionalBehVarName { get; set;}

		[RED("keepLookingAngle")] 		public CFloat KeepLookingAngle { get; set;}

		[RED("isCombatTask")] 		public CBool IsCombatTask { get; set;}

		public BTTaskLookatDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskLookatDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}