using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LessunClue : CFlyingCrittersLairEntityScript
	{
		[Ordinal(1)] [RED("pathWaypoints", 2,0)] 		public CArray<CHandle<W3ClueWaypoint>> PathWaypoints { get; set;}

		[Ordinal(2)] [RED("factTriggeredAtEnd")] 		public CString FactTriggeredAtEnd { get; set;}

		[Ordinal(3)] [RED("loopFlying")] 		public CBool LoopFlying { get; set;}

		[Ordinal(4)] [RED("swarmAttractorEntity")] 		public CHandle<CEntityTemplate> SwarmAttractorEntity { get; set;}

		[Ordinal(5)] [RED("isCurrentSoundClue")] 		public CBool IsCurrentSoundClue { get; set;}

		[Ordinal(6)] [RED("swarmAttractor")] 		public CHandle<CEntity> SwarmAttractor { get; set;}

		[Ordinal(7)] [RED("pathIndex")] 		public CInt32 PathIndex { get; set;}

		[Ordinal(8)] [RED("clueSeen")] 		public CBool ClueSeen { get; set;}

		[Ordinal(9)] [RED("targetPosition")] 		public Vector TargetPosition { get; set;}

		[Ordinal(10)] [RED("destroyTriggered")] 		public CBool DestroyTriggered { get; set;}

		[Ordinal(11)] [RED("groupPosition")] 		public Vector GroupPosition { get; set;}

		[Ordinal(12)] [RED("accuracy")] 		public CFloat Accuracy { get; set;}

		[Ordinal(13)] [RED("cameraDir")] 		public Vector CameraDir { get; set;}

		[Ordinal(14)] [RED("camHeading")] 		public CFloat CamHeading { get; set;}

		[Ordinal(15)] [RED("toClueVec")] 		public Vector ToClueVec { get; set;}

		[Ordinal(16)] [RED("toClueHeading")] 		public CFloat ToClueHeading { get; set;}

		[Ordinal(17)] [RED("currentClueState")] 		public CName CurrentClueState { get; set;}

		[Ordinal(18)] [RED("groupEffectSpawnPointComponent")] 		public CHandle<CComponent> GroupEffectSpawnPointComponent { get; set;}

		public W3LessunClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LessunClue(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}