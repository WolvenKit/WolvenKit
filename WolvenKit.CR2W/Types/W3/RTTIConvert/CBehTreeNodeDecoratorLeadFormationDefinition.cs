using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeDecoratorLeadFormationDefinition : CBehTreeDecoratorSteeringGraphDefinition
	{
		[Ordinal(0)] [RED("formation")] 		public CBehTreeValFormation Formation { get; set;}

		[Ordinal(0)] [RED("reshapeOnMoveAction")] 		public CBehTreeValBool ReshapeOnMoveAction { get; set;}

		public CBehTreeNodeDecoratorLeadFormationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeDecoratorLeadFormationDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}