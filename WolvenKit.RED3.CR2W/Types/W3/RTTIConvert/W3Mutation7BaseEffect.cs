using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Mutation7BaseEffect : CBaseGameplayEffect
	{
		[Ordinal(1)] [RED("actors", 2,0)] 		public CArray<CHandle<CActor>> Actors { get; set;}

		[Ordinal(2)] [RED("sonarEntity")] 		public CHandle<CEntity> SonarEntity { get; set;}

		[Ordinal(3)] [RED("meshComponent")] 		public CHandle<CMeshComponent> MeshComponent { get; set;}

		[Ordinal(4)] [RED("streamingHax")] 		public CBool StreamingHax { get; set;}

		[Ordinal(5)] [RED("scale")] 		public CFloat Scale { get; set;}

		[Ordinal(6)] [RED("isSonarIncreasing")] 		public CBool IsSonarIncreasing { get; set;}

		[Ordinal(7)] [RED("enemyFlashFX")] 		public CName EnemyFlashFX { get; set;}

		[Ordinal(8)] [RED("actorsCount")] 		public CInt32 ActorsCount { get; set;}

		[Ordinal(9)] [RED("apBonus")] 		public CFloat ApBonus { get; set;}

		public W3Mutation7BaseEffect(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}