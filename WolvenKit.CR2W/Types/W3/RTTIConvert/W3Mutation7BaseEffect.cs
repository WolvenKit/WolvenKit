using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Mutation7BaseEffect : CBaseGameplayEffect
	{
		[RED("actors", 2,0)] 		public CArray<CHandle<CActor>> Actors { get; set;}

		[RED("sonarEntity")] 		public CHandle<CEntity> SonarEntity { get; set;}

		[RED("meshComponent")] 		public CHandle<CMeshComponent> MeshComponent { get; set;}

		[RED("streamingHax")] 		public CBool StreamingHax { get; set;}

		[RED("scale")] 		public CFloat Scale { get; set;}

		[RED("isSonarIncreasing")] 		public CBool IsSonarIncreasing { get; set;}

		[RED("enemyFlashFX")] 		public CName EnemyFlashFX { get; set;}

		[RED("actorsCount")] 		public CInt32 ActorsCount { get; set;}

		[RED("apBonus")] 		public CFloat ApBonus { get; set;}

		public W3Mutation7BaseEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Mutation7BaseEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}