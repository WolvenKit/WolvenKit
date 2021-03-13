using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskElementalThrow : IBehTreeTask
	{
		[Ordinal(1)] [RED("physicalComponent")] 		public CHandle<CMeshComponent> PhysicalComponent { get; set;}

		[Ordinal(2)] [RED("objectEntity")] 		public CHandle<CEntityTemplate> ObjectEntity { get; set;}

		[Ordinal(3)] [RED("object")] 		public CHandle<CEntity> Object { get; set;}

		public CBTTaskElementalThrow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskElementalThrow(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}