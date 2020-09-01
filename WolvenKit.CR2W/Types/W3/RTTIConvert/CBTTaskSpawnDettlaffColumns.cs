using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnDettlaffColumns : IBehTreeTask
	{
		[Ordinal(1)] [RED("("owner")] 		public CHandle<CNewNPC> Owner { get; set;}

		[Ordinal(2)] [RED("("tempActor")] 		public CHandle<CActor> TempActor { get; set;}

		[Ordinal(3)] [RED("("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(4)] [RED("("amountToSpawn")] 		public CInt32 AmountToSpawn { get; set;}

		[Ordinal(5)] [RED("("minDistanceFromTarget")] 		public CFloat MinDistanceFromTarget { get; set;}

		[Ordinal(6)] [RED("("maxDistanceFromTarget")] 		public CFloat MaxDistanceFromTarget { get; set;}

		[Ordinal(7)] [RED("("minDistFromEachOther")] 		public CFloat MinDistFromEachOther { get; set;}

		[Ordinal(8)] [RED("("tagToFind")] 		public CName TagToFind { get; set;}

		[Ordinal(9)] [RED("("entityToFind")] 		public CHandle<CEntity> EntityToFind { get; set;}

		[Ordinal(10)] [RED("("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(11)] [RED("("shouldComplete")] 		public CBool ShouldComplete { get; set;}

		[Ordinal(12)] [RED("("summonerComponent")] 		public CHandle<W3SummonerComponent> SummonerComponent { get; set;}

		[Ordinal(13)] [RED("("usedPos", 2,0)] 		public CArray<Vector> UsedPos { get; set;}

		public CBTTaskSpawnDettlaffColumns(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnDettlaffColumns(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}