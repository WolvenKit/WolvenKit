using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskElementalThrow : IBehTreeTask
	{
		[Ordinal(0)] [RED("physicalComponent")] 		public CHandle<CMeshComponent> PhysicalComponent { get; set;}

		[Ordinal(0)] [RED("objectEntity")] 		public CHandle<CEntityTemplate> ObjectEntity { get; set;}

		[Ordinal(0)] [RED("object")] 		public CHandle<CEntity> Object { get; set;}

		public CBTTaskElementalThrow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskElementalThrow(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}