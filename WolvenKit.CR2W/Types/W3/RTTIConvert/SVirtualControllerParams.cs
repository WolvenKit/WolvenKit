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
		[RED("name")] 		public CName Name { get; set;}

		[RED("boneName")] 		public CName BoneName { get; set;}

		[RED("localOffset")] 		public Vector LocalOffset { get; set;}

		[RED("localOffsetInModelSpace")] 		public CBool LocalOffsetInModelSpace { get; set;}

		[RED("height")] 		public CFloat Height { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("targetable")] 		public CBool Targetable { get; set;}

		[RED("collisions")] 		public CBool Collisions { get; set;}

		[RED("collisionResponse")] 		public CBool CollisionResponse { get; set;}

		[RED("collisionGrabber")] 		public CBool CollisionGrabber { get; set;}

		[RED("collisionGrabberGroupNames", 2,0)] 		public CArray<CName> CollisionGrabberGroupNames { get; set;}

		[RED("onCollisionEventName")] 		public CName OnCollisionEventName { get; set;}

		[RED("additionalRaycastCheck")] 		public Vector AdditionalRaycastCheck { get; set;}

		[RED("additionalRaycastCheckEventName")] 		public CName AdditionalRaycastCheckEventName { get; set;}

		public SVirtualControllerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SVirtualControllerParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}