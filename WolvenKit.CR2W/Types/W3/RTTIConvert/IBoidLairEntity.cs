using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IBoidLairEntity : CGameplayEntity
	{
		[RED("boidSpeciesName")] 		public CName BoidSpeciesName { get; set;}

		[RED("spawnFrequency")] 		public CFloat SpawnFrequency { get; set;}

		[RED("spawnLimit")] 		public CInt32 SpawnLimit { get; set;}

		[RED("totalLifetimeSpawnLimit")] 		public CInt32 TotalLifetimeSpawnLimit { get; set;}

		[RED("lairBoundings")] 		public EntityHandle LairBoundings { get; set;}

		[RED("range")] 		public CFloat Range { get; set;}

		[RED("visibilityRange")] 		public CFloat VisibilityRange { get; set;}

		public IBoidLairEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new IBoidLairEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}