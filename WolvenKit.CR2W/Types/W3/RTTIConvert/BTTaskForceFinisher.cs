using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskForceFinisher : IBehTreeTask
	{
		[Ordinal(0)] [RED("belowHealthPercent")] 		public CFloat BelowHealthPercent { get; set;}

		[Ordinal(0)] [RED("whenAlone")] 		public CBool WhenAlone { get; set;}

		[Ordinal(0)] [RED("leftStanceFinisherAnimName")] 		public CName LeftStanceFinisherAnimName { get; set;}

		[Ordinal(0)] [RED("rightStanceFinisherAnimName")] 		public CName RightStanceFinisherAnimName { get; set;}

		[Ordinal(0)] [RED("hasFinisherDLC")] 		public CBool HasFinisherDLC { get; set;}

		[Ordinal(0)] [RED("shouldCheckForFinisherDLC")] 		public CBool ShouldCheckForFinisherDLC { get; set;}

		[Ordinal(0)] [RED("m_Npc")] 		public CHandle<CNewNPC> M_Npc { get; set;}

		public BTTaskForceFinisher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskForceFinisher(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}