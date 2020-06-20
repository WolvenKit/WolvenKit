using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBaseCreatureEntry : ISpawnTreeLeafNode
	{
		[RED("initializers", 2,0)] 		public CArray<CHandle<ISpawnTreeInitializer>> Initializers { get; set;}

		[RED("quantityMin")] 		public CInt32 QuantityMin { get; set;}

		[RED("quantityMax")] 		public CInt32 QuantityMax { get; set;}

		[RED("spawnInterval")] 		public CFloat SpawnInterval { get; set;}

		[RED("waveDelay")] 		public CFloat WaveDelay { get; set;}

		[RED("waveCounterHitAtDeathRatio")] 		public CFloat WaveCounterHitAtDeathRatio { get; set;}

		[RED("randomizeRotation")] 		public CBool RandomizeRotation { get; set;}

		[RED("group")] 		public CInt32 Group { get; set;}

		[RED("baseSpawner")] 		public CSpawnTreeWaypointSpawner BaseSpawner { get; set;}

		[RED("recalculateDelay")] 		public GameTime RecalculateDelay { get; set;}

		public CBaseCreatureEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBaseCreatureEntry(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}