using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeCombatTicketManagedGetDefinition : CBehTreeNodeCombatTicketManagerDefinition
	{
		[RED("locksTicket")] 		public CBool LocksTicket { get; set;}

		[RED("freesTicket")] 		public CBool FreesTicket { get; set;}

		[RED("failsWhenTicketIsLost")] 		public CBool FailsWhenTicketIsLost { get; set;}

		[RED("ticketRequestValidTime")] 		public CFloat TicketRequestValidTime { get; set;}

		public CBehTreeNodeCombatTicketManagedGetDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeCombatTicketManagedGetDefinition(cr2w);

	}
}