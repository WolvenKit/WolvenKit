using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MeteorItem : W3QuestUsableItem
	{
		[Ordinal(1)] [RED("collisionGroups", 2,0)] 		public CArray<CName> CollisionGroups { get; set;}

		[Ordinal(2)] [RED("meteorResourceName")] 		public CName MeteorResourceName { get; set;}

		[Ordinal(3)] [RED("meteorEntityTemplate")] 		public CHandle<CEntityTemplate> MeteorEntityTemplate { get; set;}

		public W3MeteorItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MeteorItem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}