using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskTackle : IBehTreeTask
	{
		[Ordinal(1)] [RED("dealDamage")] 		public CBool DealDamage { get; set;}

		[Ordinal(2)] [RED("activeOnAnimEvent")] 		public CBool ActiveOnAnimEvent { get; set;}

		[Ordinal(3)] [RED("bCollisionWithActor")] 		public CBool BCollisionWithActor { get; set;}

		[Ordinal(4)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(5)] [RED("xmlDamageName")] 		public CName XmlDamageName { get; set;}

		[Ordinal(6)] [RED("collidedActor")] 		public CHandle<CActor> CollidedActor { get; set;}

		public CBTTaskTackle(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskTackle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}