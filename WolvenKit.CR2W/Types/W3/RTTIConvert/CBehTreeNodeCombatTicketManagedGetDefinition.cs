using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeCombatTicketManagedGetDefinition : CBehTreeNodeCombatTicketManagerDefinition
	{
		[Ordinal(1)] [RED("locksTicket")] 		public CBool LocksTicket { get; set;}

		[Ordinal(2)] [RED("freesTicket")] 		public CBool FreesTicket { get; set;}

		[Ordinal(3)] [RED("failsWhenTicketIsLost")] 		public CBool FailsWhenTicketIsLost { get; set;}

		[Ordinal(4)] [RED("ticketRequestValidTime")] 		public CFloat TicketRequestValidTime { get; set;}

		public CBehTreeNodeCombatTicketManagedGetDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeCombatTicketManagedGetDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}