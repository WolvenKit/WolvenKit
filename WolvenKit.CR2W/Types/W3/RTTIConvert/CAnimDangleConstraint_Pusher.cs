using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_Pusher : CAnimSkeletalDangleConstraint
	{
		[RED("boneName")] 		public CString BoneName { get; set;}

		[RED("collisionName")] 		public CString CollisionName { get; set;}

		[RED("offset")] 		public Vector Offset { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("maxAngle")] 		public CFloat MaxAngle { get; set;}

		public CAnimDangleConstraint_Pusher(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAnimDangleConstraint_Pusher(cr2w);

	}
}