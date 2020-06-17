using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskForceFinisherDef : IBehTreeTaskDefinition
	{
		[RED("belowHealthPercent")] 		public CFloat BelowHealthPercent { get; set;}

		[RED("whenAlone")] 		public CBool WhenAlone { get; set;}

		[RED("leftStanceFinisherAnimName")] 		public CName LeftStanceFinisherAnimName { get; set;}

		[RED("rightStanceFinisherAnimName")] 		public CName RightStanceFinisherAnimName { get; set;}

		[RED("shouldCheckForFinisherDLC")] 		public CBool ShouldCheckForFinisherDLC { get; set;}

		public BTTaskForceFinisherDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskForceFinisherDef(cr2w);

	}
}