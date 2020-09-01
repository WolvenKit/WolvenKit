using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_Pusher : CAnimSkeletalDangleConstraint
	{
		[Ordinal(0)] [RED("boneName")] 		public CString BoneName { get; set;}

		[Ordinal(0)] [RED("collisionName")] 		public CString CollisionName { get; set;}

		[Ordinal(0)] [RED("offset")] 		public Vector Offset { get; set;}

		[Ordinal(0)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(0)] [RED("maxAngle")] 		public CFloat MaxAngle { get; set;}

		public CAnimDangleConstraint_Pusher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimDangleConstraint_Pusher(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}