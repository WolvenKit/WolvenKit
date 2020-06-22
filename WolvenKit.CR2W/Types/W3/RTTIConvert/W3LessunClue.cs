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
		[RED("pathWaypoints", 2,0)] 		public CArray<CHandle<W3ClueWaypoint>> PathWaypoints { get; set;}

		[RED("factTriggeredAtEnd")] 		public CString FactTriggeredAtEnd { get; set;}

		[RED("loopFlying")] 		public CBool LoopFlying { get; set;}

		[RED("swarmAttractorEntity")] 		public CHandle<CEntityTemplate> SwarmAttractorEntity { get; set;}

		[RED("isCurrentSoundClue")] 		public CBool IsCurrentSoundClue { get; set;}

		[RED("swarmAttractor")] 		public CHandle<CEntity> SwarmAttractor { get; set;}

		[RED("pathIndex")] 		public CInt32 PathIndex { get; set;}

		[RED("clueSeen")] 		public CBool ClueSeen { get; set;}

		[RED("targetPosition")] 		public Vector TargetPosition { get; set;}

		[RED("destroyTriggered")] 		public CBool DestroyTriggered { get; set;}

		[RED("groupPosition")] 		public Vector GroupPosition { get; set;}

		[RED("accuracy")] 		public CFloat Accuracy { get; set;}

		[RED("cameraDir")] 		public Vector CameraDir { get; set;}

		[RED("camHeading")] 		public CFloat CamHeading { get; set;}

		[RED("toClueVec")] 		public Vector ToClueVec { get; set;}

		[RED("toClueHeading")] 		public CFloat ToClueHeading { get; set;}

		[RED("currentClueState")] 		public CName CurrentClueState { get; set;}

		[RED("groupEffectSpawnPointComponent")] 		public CHandle<CComponent> GroupEffectSpawnPointComponent { get; set;}

		public W3LessunClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LessunClue(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}