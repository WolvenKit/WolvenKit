using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LessunClue : CFlyingCrittersLairEntityScript
	{
		[Ordinal(0)] [RED("("pathWaypoints", 2,0)] 		public CArray<CHandle<W3ClueWaypoint>> PathWaypoints { get; set;}

		[Ordinal(0)] [RED("("factTriggeredAtEnd")] 		public CString FactTriggeredAtEnd { get; set;}

		[Ordinal(0)] [RED("("loopFlying")] 		public CBool LoopFlying { get; set;}

		[Ordinal(0)] [RED("("swarmAttractorEntity")] 		public CHandle<CEntityTemplate> SwarmAttractorEntity { get; set;}

		[Ordinal(0)] [RED("("isCurrentSoundClue")] 		public CBool IsCurrentSoundClue { get; set;}

		[Ordinal(0)] [RED("("swarmAttractor")] 		public CHandle<CEntity> SwarmAttractor { get; set;}

		[Ordinal(0)] [RED("("pathIndex")] 		public CInt32 PathIndex { get; set;}

		[Ordinal(0)] [RED("("clueSeen")] 		public CBool ClueSeen { get; set;}

		[Ordinal(0)] [RED("("targetPosition")] 		public Vector TargetPosition { get; set;}

		[Ordinal(0)] [RED("("destroyTriggered")] 		public CBool DestroyTriggered { get; set;}

		[Ordinal(0)] [RED("("groupPosition")] 		public Vector GroupPosition { get; set;}

		[Ordinal(0)] [RED("("accuracy")] 		public CFloat Accuracy { get; set;}

		[Ordinal(0)] [RED("("cameraDir")] 		public Vector CameraDir { get; set;}

		[Ordinal(0)] [RED("("camHeading")] 		public CFloat CamHeading { get; set;}

		[Ordinal(0)] [RED("("toClueVec")] 		public Vector ToClueVec { get; set;}

		[Ordinal(0)] [RED("("toClueHeading")] 		public CFloat ToClueHeading { get; set;}

		[Ordinal(0)] [RED("("currentClueState")] 		public CName CurrentClueState { get; set;}

		[Ordinal(0)] [RED("("groupEffectSpawnPointComponent")] 		public CHandle<CComponent> GroupEffectSpawnPointComponent { get; set;}

		public W3LessunClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LessunClue(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}