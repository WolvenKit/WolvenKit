using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_Pusher : CAnimSkeletalDangleConstraint
	{
		[Ordinal(1)] [RED("boneName")] 		public CString BoneName { get; set;}

		[Ordinal(2)] [RED("collisionName")] 		public CString CollisionName { get; set;}

		[Ordinal(3)] [RED("offset")] 		public Vector Offset { get; set;}

		[Ordinal(4)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(5)] [RED("maxAngle")] 		public CFloat MaxAngle { get; set;}

		public CAnimDangleConstraint_Pusher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimDangleConstraint_Pusher(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}