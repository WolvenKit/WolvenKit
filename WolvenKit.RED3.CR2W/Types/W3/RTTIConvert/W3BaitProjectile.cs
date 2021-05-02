using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3BaitProjectile : W3BoltProjectile
	{
		[Ordinal(1)] [RED("foodSourceToGenerate")] 		public CHandle<CEntityTemplate> FoodSourceToGenerate { get; set;}

		[Ordinal(2)] [RED("addScentToCollidedActors")] 		public CBool AddScentToCollidedActors { get; set;}

		[Ordinal(3)] [RED("attractionDuration")] 		public CFloat AttractionDuration { get; set;}

		[Ordinal(4)] [RED("m_BaitEntity")] 		public CHandle<CEntity> M_BaitEntity { get; set;}

		public W3BaitProjectile(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3BaitProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}