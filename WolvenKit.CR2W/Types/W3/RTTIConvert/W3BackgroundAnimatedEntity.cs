using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3BackgroundAnimatedEntity : CGameplayEntity
	{
		[RED("backgroundEntityData", 2,0)] 		public CArray<SBackgroundEntityData> BackgroundEntityData { get; set;}

		[RED("parentEntity")] 		public CHandle<CEntityTemplate> ParentEntity { get; set;}

		[RED("maxSpeed")] 		public CFloat MaxSpeed { get; set;}

		[RED("acceleration")] 		public CFloat Acceleration { get; set;}

		[RED("maxAngleSpeed")] 		public CFloat MaxAngleSpeed { get; set;}

		[RED("waypointDistance")] 		public CFloat WaypointDistance { get; set;}

		[RED("waypoints", 2,0)] 		public CArray<EntityHandle> Waypoints { get; set;}

		[RED("loopMotion")] 		public CBool LoopMotion { get; set;}

		[RED("startAtSpawn")] 		public CBool StartAtSpawn { get; set;}

		[RED("maxAngleSpeedThreshold")] 		public CFloat MaxAngleSpeedThreshold { get; set;}

		[RED("angleAcceleration")] 		public CFloat AngleAcceleration { get; set;}

		[RED("stoppingDistance")] 		public CFloat StoppingDistance { get; set;}

		[RED("endPositionError")] 		public CFloat EndPositionError { get; set;}

		[RED("angleSpeed")] 		public CFloat AngleSpeed { get; set;}

		[RED("speedScale")] 		public CFloat SpeedScale { get; set;}

		[RED("previousAngleDistance")] 		public CFloat PreviousAngleDistance { get; set;}

		[RED("nodes", 2,0)] 		public CArray<CHandle<CNode>> Nodes { get; set;}

		[RED("i")] 		public CInt32 I { get; set;}

		[RED("size")] 		public CInt32 Size { get; set;}

		[RED("currTargetIndex")] 		public CInt32 CurrTargetIndex { get; set;}

		[RED("canMove")] 		public CBool CanMove { get; set;}

		[RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[RED("entityToAttach")] 		public CHandle<CEntity> EntityToAttach { get; set;}

		[RED("currTarget")] 		public CHandle<CNode> CurrTarget { get; set;}

		[RED("position")] 		public Vector Position { get; set;}

		[RED("targetPos")] 		public Vector TargetPos { get; set;}

		[RED("currPosition")] 		public Vector CurrPosition { get; set;}

		[RED("direction")] 		public Vector Direction { get; set;}

		[RED("toTarget")] 		public Vector ToTarget { get; set;}

		[RED("angleDistancePlus")] 		public CFloat AngleDistancePlus { get; set;}

		[RED("angleDistanceMinus")] 		public CFloat AngleDistanceMinus { get; set;}

		[RED("angleDistance")] 		public CFloat AngleDistance { get; set;}

		[RED("distanceToTarget")] 		public CFloat DistanceToTarget { get; set;}

		[RED("rotation")] 		public EulerAngles Rotation { get; set;}

		[RED("desiredRotation")] 		public EulerAngles DesiredRotation { get; set;}

		[RED("speed")] 		public CFloat Speed { get; set;}

		[RED("shouldStop")] 		public CBool ShouldStop { get; set;}

		[RED("maxCurrentAngleSpeed")] 		public CFloat MaxCurrentAngleSpeed { get; set;}

		[RED("maxCurrentSpeed")] 		public CFloat MaxCurrentSpeed { get; set;}

		public W3BackgroundAnimatedEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3BackgroundAnimatedEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}