using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SVirtualControllerParams : CVariable
	{
		[Ordinal(1)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(2)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(3)] [RED("localOffset")] 		public Vector LocalOffset { get; set;}

		[Ordinal(4)] [RED("localOffsetInModelSpace")] 		public CBool LocalOffsetInModelSpace { get; set;}

		[Ordinal(5)] [RED("height")] 		public CFloat Height { get; set;}

		[Ordinal(6)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(7)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(8)] [RED("targetable")] 		public CBool Targetable { get; set;}

		[Ordinal(9)] [RED("collisions")] 		public CBool Collisions { get; set;}

		[Ordinal(10)] [RED("collisionResponse")] 		public CBool CollisionResponse { get; set;}

		[Ordinal(11)] [RED("collisionGrabber")] 		public CBool CollisionGrabber { get; set;}

		[Ordinal(12)] [RED("collisionGrabberGroupNames", 2,0)] 		public CArray<CName> CollisionGrabberGroupNames { get; set;}

		[Ordinal(13)] [RED("onCollisionEventName")] 		public CName OnCollisionEventName { get; set;}

		[Ordinal(14)] [RED("additionalRaycastCheck")] 		public Vector AdditionalRaycastCheck { get; set;}

		[Ordinal(15)] [RED("additionalRaycastCheckEventName")] 		public CName AdditionalRaycastCheckEventName { get; set;}

		public SVirtualControllerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SVirtualControllerParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}