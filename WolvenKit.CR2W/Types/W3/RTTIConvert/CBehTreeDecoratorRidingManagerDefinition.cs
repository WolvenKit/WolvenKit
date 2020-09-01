using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeDecoratorRidingManagerDefinition : IBehTreeNodeSpecialDefinition
	{
		[Ordinal(0)] [RED("child")] 		public CPtr<IBehTreeNodeDefinition> Child { get; set;}

		[Ordinal(0)] [RED("mountHorseChild")] 		public CPtr<IBehTreeNodeDefinition> MountHorseChild { get; set;}

		[Ordinal(0)] [RED("dismountHorseChild")] 		public CPtr<IBehTreeNodeDefinition> DismountHorseChild { get; set;}

		[Ordinal(0)] [RED("mountBoatChild")] 		public CPtr<IBehTreeNodeDefinition> MountBoatChild { get; set;}

		[Ordinal(0)] [RED("dismountBoatChild")] 		public CPtr<IBehTreeNodeDefinition> DismountBoatChild { get; set;}

		public CBehTreeDecoratorRidingManagerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeDecoratorRidingManagerDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}