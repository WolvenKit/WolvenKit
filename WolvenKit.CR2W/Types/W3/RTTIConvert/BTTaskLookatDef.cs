using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskLookatDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("lookatAtStart")] 		public CBool LookatAtStart { get; set;}

		[Ordinal(0)] [RED("headBoneName")] 		public CName HeadBoneName { get; set;}

		[Ordinal(0)] [RED("useHeadBoneRotation")] 		public CBool UseHeadBoneRotation { get; set;}

		[Ordinal(0)] [RED("keepLooking")] 		public CBool KeepLooking { get; set;}

		[Ordinal(0)] [RED("verticalLookAt")] 		public CBool VerticalLookAt { get; set;}

		[Ordinal(0)] [RED("setAdditionalBehVar")] 		public CBool SetAdditionalBehVar { get; set;}

		[Ordinal(0)] [RED("additionalBehVarName")] 		public CName AdditionalBehVarName { get; set;}

		[Ordinal(0)] [RED("keepLookingAngle")] 		public CFloat KeepLookingAngle { get; set;}

		[Ordinal(0)] [RED("isCombatTask")] 		public CBool IsCombatTask { get; set;}

		public BTTaskLookatDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskLookatDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}