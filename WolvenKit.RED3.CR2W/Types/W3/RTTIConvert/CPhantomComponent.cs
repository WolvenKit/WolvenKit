using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPhantomComponent : CComponent
	{
		[Ordinal(1)] [RED("collisionGroupName")] 		public CName CollisionGroupName { get; set;}

		[Ordinal(2)] [RED("triggeringCollisionGroupNames", 2,0)] 		public CArray<CName> TriggeringCollisionGroupNames { get; set;}

		[Ordinal(3)] [RED("shapeType")] 		public CEnum<EPhantomShape> ShapeType { get; set;}

		[Ordinal(4)] [RED("shapeDimensions")] 		public Vector ShapeDimensions { get; set;}

		[Ordinal(5)] [RED("onTriggerEnteredScriptEvent")] 		public CName OnTriggerEnteredScriptEvent { get; set;}

		[Ordinal(6)] [RED("onTriggerExitedScriptEvent")] 		public CName OnTriggerExitedScriptEvent { get; set;}

		[Ordinal(7)] [RED("eventsCalledOnComponent")] 		public CBool EventsCalledOnComponent { get; set;}

		[Ordinal(8)] [RED("useInQueries")] 		public CBool UseInQueries { get; set;}

		[Ordinal(9)] [RED("meshCollision")] 		public CHandle<CMesh> MeshCollision { get; set;}

		public CPhantomComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPhantomComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}