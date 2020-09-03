using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskLookatDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("lookatAtStart")] 		public CBool LookatAtStart { get; set;}

		[Ordinal(2)] [RED("headBoneName")] 		public CName HeadBoneName { get; set;}

		[Ordinal(3)] [RED("useHeadBoneRotation")] 		public CBool UseHeadBoneRotation { get; set;}

		[Ordinal(4)] [RED("keepLooking")] 		public CBool KeepLooking { get; set;}

		[Ordinal(5)] [RED("verticalLookAt")] 		public CBool VerticalLookAt { get; set;}

		[Ordinal(6)] [RED("setAdditionalBehVar")] 		public CBool SetAdditionalBehVar { get; set;}

		[Ordinal(7)] [RED("additionalBehVarName")] 		public CName AdditionalBehVarName { get; set;}

		[Ordinal(8)] [RED("keepLookingAngle")] 		public CFloat KeepLookingAngle { get; set;}

		[Ordinal(9)] [RED("isCombatTask")] 		public CBool IsCombatTask { get; set;}

		public BTTaskLookatDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskLookatDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}