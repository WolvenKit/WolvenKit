using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSEntitiesEntry : CVariable
	{
		[RED("entityTemplate")] 		public CSoft<CEntityTemplate> EntityTemplate { get; set;}

		[RED("appearances", 2,0)] 		public CArray<CName> Appearances { get; set;}

		[RED("entitySpawnTags")] 		public TagList EntitySpawnTags { get; set;}

		[RED("mappinTag")] 		public CName MappinTag { get; set;}

		[RED("mappinType")] 		public CEnum<ECommMapPinType> MappinType { get; set;}

		[RED("initializers")] 		public CPtr<CCommunityInitializers> Initializers { get; set;}

		[RED("guid")] 		public CGUID Guid { get; set;}

		[RED("despawners")] 		public CPtr<CCommunityInitializers> Despawners { get; set;}

		public CSEntitiesEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSEntitiesEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}