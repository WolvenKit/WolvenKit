using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestSpawnNotStreamedBoatBlock : CQuestGraphBlock
	{
		[RED("spawnPointTag")] 		public CName SpawnPointTag { get; set;}

		[RED("tagsToSet", 2,0)] 		public CArray<CName> TagsToSet { get; set;}

		[RED("spawnLayerTag")] 		public CName SpawnLayerTag { get; set;}

		[RED("forceNonStreamed")] 		public CBool ForceNonStreamed { get; set;}

		public CQuestSpawnNotStreamedBoatBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestSpawnNotStreamedBoatBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}