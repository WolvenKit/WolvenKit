using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SVirtualControllerParams : CVariable
	{
		[Ordinal(0)] [RED("("name")] 		public CName Name { get; set;}

		[Ordinal(0)] [RED("("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(0)] [RED("("localOffset")] 		public Vector LocalOffset { get; set;}

		[Ordinal(0)] [RED("("localOffsetInModelSpace")] 		public CBool LocalOffsetInModelSpace { get; set;}

		[Ordinal(0)] [RED("("height")] 		public CFloat Height { get; set;}

		[Ordinal(0)] [RED("("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(0)] [RED("("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(0)] [RED("("targetable")] 		public CBool Targetable { get; set;}

		[Ordinal(0)] [RED("("collisions")] 		public CBool Collisions { get; set;}

		[Ordinal(0)] [RED("("collisionResponse")] 		public CBool CollisionResponse { get; set;}

		[Ordinal(0)] [RED("("collisionGrabber")] 		public CBool CollisionGrabber { get; set;}

		[Ordinal(0)] [RED("("collisionGrabberGroupNames", 2,0)] 		public CArray<CName> CollisionGrabberGroupNames { get; set;}

		[Ordinal(0)] [RED("("onCollisionEventName")] 		public CName OnCollisionEventName { get; set;}

		[Ordinal(0)] [RED("("additionalRaycastCheck")] 		public Vector AdditionalRaycastCheck { get; set;}

		[Ordinal(0)] [RED("("additionalRaycastCheckEventName")] 		public CName AdditionalRaycastCheckEventName { get; set;}

		public SVirtualControllerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SVirtualControllerParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}