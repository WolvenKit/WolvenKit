using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CurveFishManager : CGameplayEntity
	{
		[Ordinal(1)] [RED("fishSpawnPointsTag")] 		public CName FishSpawnPointsTag { get; set;}

		[Ordinal(2)] [RED("fishTemplate", 2,0)] 		public CArray<CHandle<CEntityTemplate>> FishTemplate { get; set;}

		[Ordinal(3)] [RED("randomFishRotation")] 		public CBool RandomFishRotation { get; set;}

		[Ordinal(4)] [RED("fishSpawnpoints", 2,0)] 		public CArray<SFishSpawnpoint> FishSpawnpoints { get; set;}

		[Ordinal(5)] [RED("m_spawnDistance")] 		public CFloat M_spawnDistance { get; set;}

		[Ordinal(6)] [RED("m_despawnDistance")] 		public CFloat M_despawnDistance { get; set;}

		[Ordinal(7)] [RED("m_spawned")] 		public CBool M_spawned { get; set;}

		[Ordinal(8)] [RED("m_firstTimeCollectSpawnpoints")] 		public CBool M_firstTimeCollectSpawnpoints { get; set;}

		[Ordinal(9)] [RED("m_spawnedFish", 2,0)] 		public CArray<CHandle<W3CurveFish>> M_spawnedFish { get; set;}

		public W3CurveFishManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3CurveFishManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}