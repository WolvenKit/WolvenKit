using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeCombatTicketManagerDefinition : IBehTreeNodeCombatTicketDecoratorBaseDefinition
	{
		[Ordinal(1)] [RED("ticketsCount")] 		public CBehTreeValInt TicketsCount { get; set;}

		[Ordinal(2)] [RED("importanceUpdateDelay")] 		public CFloat ImportanceUpdateDelay { get; set;}

		[Ordinal(3)] [RED("ticketAlgorithm")] 		public CPtr<IBehTreeTicketAlgorithmDefinition> TicketAlgorithm { get; set;}

		public CBehTreeNodeCombatTicketManagerDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}