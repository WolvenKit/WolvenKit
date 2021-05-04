using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeCombatTicketManagedGetDefinition : CBehTreeNodeCombatTicketManagerDefinition
	{
		[Ordinal(1)] [RED("locksTicket")] 		public CBool LocksTicket { get; set;}

		[Ordinal(2)] [RED("freesTicket")] 		public CBool FreesTicket { get; set;}

		[Ordinal(3)] [RED("failsWhenTicketIsLost")] 		public CBool FailsWhenTicketIsLost { get; set;}

		[Ordinal(4)] [RED("ticketRequestValidTime")] 		public CFloat TicketRequestValidTime { get; set;}

		public CBehTreeNodeCombatTicketManagedGetDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}