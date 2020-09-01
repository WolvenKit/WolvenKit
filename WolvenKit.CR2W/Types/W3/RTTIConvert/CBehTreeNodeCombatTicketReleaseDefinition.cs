using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeCombatTicketReleaseDefinition : IBehTreeNodeCombatTicketDecoratorBaseDefinition
	{
		[Ordinal(0)] [RED("releaseOnActivation")] 		public CBool ReleaseOnActivation { get; set;}

		[Ordinal(0)] [RED("releaseOnDeactivation")] 		public CBool ReleaseOnDeactivation { get; set;}

		[Ordinal(0)] [RED("releaseOnCompletion")] 		public CBool ReleaseOnCompletion { get; set;}

		public CBehTreeNodeCombatTicketReleaseDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeCombatTicketReleaseDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}