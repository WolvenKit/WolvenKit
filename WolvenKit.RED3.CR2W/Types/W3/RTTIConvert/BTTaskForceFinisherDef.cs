using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskForceFinisherDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("belowHealthPercent")] 		public CFloat BelowHealthPercent { get; set;}

		[Ordinal(2)] [RED("whenAlone")] 		public CBool WhenAlone { get; set;}

		[Ordinal(3)] [RED("leftStanceFinisherAnimName")] 		public CName LeftStanceFinisherAnimName { get; set;}

		[Ordinal(4)] [RED("rightStanceFinisherAnimName")] 		public CName RightStanceFinisherAnimName { get; set;}

		[Ordinal(5)] [RED("shouldCheckForFinisherDLC")] 		public CBool ShouldCheckForFinisherDLC { get; set;}

		[Ordinal(6)] [RED("hasFinisherDLC")] 		public CBool HasFinisherDLC { get; set;}

		public BTTaskForceFinisherDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskForceFinisherDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}