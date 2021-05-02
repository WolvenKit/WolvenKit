using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3BackgroundAnimatedEntity : CGameplayEntity
	{
		[Ordinal(1)] [RED("backgroundEntityData", 2,0)] 		public CArray<SBackgroundEntityData> BackgroundEntityData { get; set;}

		[Ordinal(2)] [RED("parentEntity")] 		public CHandle<CEntityTemplate> ParentEntity { get; set;}

		[Ordinal(3)] [RED("maxSpeed")] 		public CFloat MaxSpeed { get; set;}

		[Ordinal(4)] [RED("acceleration")] 		public CFloat Acceleration { get; set;}

		[Ordinal(5)] [RED("maxAngleSpeed")] 		public CFloat MaxAngleSpeed { get; set;}

		[Ordinal(6)] [RED("waypointDistance")] 		public CFloat WaypointDistance { get; set;}

		[Ordinal(7)] [RED("waypoints", 2,0)] 		public CArray<EntityHandle> Waypoints { get; set;}

		[Ordinal(8)] [RED("loopMotion")] 		public CBool LoopMotion { get; set;}

		[Ordinal(9)] [RED("startAtSpawn")] 		public CBool StartAtSpawn { get; set;}

		[Ordinal(10)] [RED("maxAngleSpeedThreshold")] 		public CFloat MaxAngleSpeedThreshold { get; set;}

		[Ordinal(11)] [RED("angleAcceleration")] 		public CFloat AngleAcceleration { get; set;}

		[Ordinal(12)] [RED("stoppingDistance")] 		public CFloat StoppingDistance { get; set;}

		[Ordinal(13)] [RED("endPositionError")] 		public CFloat EndPositionError { get; set;}

		[Ordinal(14)] [RED("angleSpeed")] 		public CFloat AngleSpeed { get; set;}

		[Ordinal(15)] [RED("speedScale")] 		public CFloat SpeedScale { get; set;}

		[Ordinal(16)] [RED("previousAngleDistance")] 		public CFloat PreviousAngleDistance { get; set;}

		[Ordinal(17)] [RED("nodes", 2,0)] 		public CArray<CHandle<CNode>> Nodes { get; set;}

		[Ordinal(18)] [RED("i")] 		public CInt32 I { get; set;}

		[Ordinal(19)] [RED("size")] 		public CInt32 Size { get; set;}

		[Ordinal(20)] [RED("currTargetIndex")] 		public CInt32 CurrTargetIndex { get; set;}

		[Ordinal(21)] [RED("canMove")] 		public CBool CanMove { get; set;}

		[Ordinal(22)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(23)] [RED("entityToAttach")] 		public CHandle<CEntity> EntityToAttach { get; set;}

		[Ordinal(24)] [RED("currTarget")] 		public CHandle<CNode> CurrTarget { get; set;}

		[Ordinal(25)] [RED("position")] 		public Vector Position { get; set;}

		[Ordinal(26)] [RED("targetPos")] 		public Vector TargetPos { get; set;}

		[Ordinal(27)] [RED("currPosition")] 		public Vector CurrPosition { get; set;}

		[Ordinal(28)] [RED("direction")] 		public Vector Direction { get; set;}

		[Ordinal(29)] [RED("toTarget")] 		public Vector ToTarget { get; set;}

		[Ordinal(30)] [RED("angleDistancePlus")] 		public CFloat AngleDistancePlus { get; set;}

		[Ordinal(31)] [RED("angleDistanceMinus")] 		public CFloat AngleDistanceMinus { get; set;}

		[Ordinal(32)] [RED("angleDistance")] 		public CFloat AngleDistance { get; set;}

		[Ordinal(33)] [RED("distanceToTarget")] 		public CFloat DistanceToTarget { get; set;}

		[Ordinal(34)] [RED("rotation")] 		public EulerAngles Rotation { get; set;}

		[Ordinal(35)] [RED("desiredRotation")] 		public EulerAngles DesiredRotation { get; set;}

		[Ordinal(36)] [RED("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(37)] [RED("shouldStop")] 		public CBool ShouldStop { get; set;}

		[Ordinal(38)] [RED("maxCurrentAngleSpeed")] 		public CFloat MaxCurrentAngleSpeed { get; set;}

		[Ordinal(39)] [RED("maxCurrentSpeed")] 		public CFloat MaxCurrentSpeed { get; set;}

		public W3BackgroundAnimatedEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3BackgroundAnimatedEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}