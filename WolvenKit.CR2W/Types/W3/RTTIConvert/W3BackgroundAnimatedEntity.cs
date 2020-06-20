using System.IO;using System.Runtime.Serialization;
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

		public W3BackgroundAnimatedEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3BackgroundAnimatedEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}