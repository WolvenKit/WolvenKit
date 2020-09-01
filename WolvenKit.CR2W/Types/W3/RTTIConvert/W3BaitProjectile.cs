using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3BaitProjectile : W3BoltProjectile
	{
		[Ordinal(0)] [RED("("foodSourceToGenerate")] 		public CHandle<CEntityTemplate> FoodSourceToGenerate { get; set;}

		[Ordinal(0)] [RED("("addScentToCollidedActors")] 		public CBool AddScentToCollidedActors { get; set;}

		[Ordinal(0)] [RED("("attractionDuration")] 		public CFloat AttractionDuration { get; set;}

		[Ordinal(0)] [RED("("m_BaitEntity")] 		public CHandle<CEntity> M_BaitEntity { get; set;}

		public W3BaitProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3BaitProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}