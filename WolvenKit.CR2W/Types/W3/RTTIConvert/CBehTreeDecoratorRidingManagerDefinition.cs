using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeDecoratorRidingManagerDefinition : IBehTreeNodeSpecialDefinition
	{
		[RED("child")] 		public CPtr<IBehTreeNodeDefinition> Child { get; set;}

		[RED("mountHorseChild")] 		public CPtr<IBehTreeNodeDefinition> MountHorseChild { get; set;}

		[RED("dismountHorseChild")] 		public CPtr<IBehTreeNodeDefinition> DismountHorseChild { get; set;}

		[RED("mountBoatChild")] 		public CPtr<IBehTreeNodeDefinition> MountBoatChild { get; set;}

		[RED("dismountBoatChild")] 		public CPtr<IBehTreeNodeDefinition> DismountBoatChild { get; set;}

		public CBehTreeDecoratorRidingManagerDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeDecoratorRidingManagerDefinition(cr2w);

	}
}