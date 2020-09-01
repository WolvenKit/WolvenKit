using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeCombatTicketManagerDefinition : IBehTreeNodeCombatTicketDecoratorBaseDefinition
	{
		[Ordinal(0)] [RED("ticketsCount")] 		public CBehTreeValInt TicketsCount { get; set;}

		[Ordinal(0)] [RED("importanceUpdateDelay")] 		public CFloat ImportanceUpdateDelay { get; set;}

		[Ordinal(0)] [RED("ticketAlgorithm")] 		public CPtr<IBehTreeTicketAlgorithmDefinition> TicketAlgorithm { get; set;}

		public CBehTreeNodeCombatTicketManagerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeCombatTicketManagerDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}