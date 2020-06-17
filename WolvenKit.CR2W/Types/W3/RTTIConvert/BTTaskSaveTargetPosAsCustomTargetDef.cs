using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskSaveTargetPosAsCustomTargetDef : IBehTreeTaskDefinition
	{
		[RED("useActionTarget")] 		public CBool UseActionTarget { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("snapToGround")] 		public CBool SnapToGround { get; set;}

		public BTTaskSaveTargetPosAsCustomTargetDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskSaveTargetPosAsCustomTargetDef(cr2w);

	}
}