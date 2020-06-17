using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeCombatTicketRequestDefinition : IBehTreeNodeCombatTicketDecoratorBaseDefinition
	{
		[RED("ticketRequestValidTime")] 		public CFloat TicketRequestValidTime { get; set;}

		[RED("requestOnCompletion")] 		public CBool RequestOnCompletion { get; set;}

		[RED("requestOnInterruption")] 		public CBool RequestOnInterruption { get; set;}

		[RED("requestWhileActive")] 		public CBool RequestWhileActive { get; set;}

		public CBehTreeNodeCombatTicketRequestDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeCombatTicketRequestDefinition(cr2w);

	}
}