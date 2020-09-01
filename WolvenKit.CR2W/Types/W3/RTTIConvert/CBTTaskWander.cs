using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWander : IBehTreeTask
	{
		[Ordinal(1)] [RED("("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(2)] [RED("("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(3)] [RED("("minSpeed")] 		public CFloat MinSpeed { get; set;}

		[Ordinal(4)] [RED("("maxSpeed")] 		public CFloat MaxSpeed { get; set;}

		[Ordinal(5)] [RED("("absSpeed")] 		public CFloat AbsSpeed { get; set;}

		[Ordinal(6)] [RED("("headingChange")] 		public CFloat HeadingChange { get; set;}

		[Ordinal(7)] [RED("("heading")] 		public CFloat Heading { get; set;}

		[Ordinal(8)] [RED("("initialPosCheck")] 		public CBool InitialPosCheck { get; set;}

		[Ordinal(9)] [RED("("isMoving")] 		public CBool IsMoving { get; set;}

		[Ordinal(10)] [RED("("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(11)] [RED("("initialPos")] 		public Vector InitialPos { get; set;}

		[Ordinal(12)] [RED("("newHeading")] 		public Vector NewHeading { get; set;}

		[Ordinal(13)] [RED("("checkPos")] 		public Vector CheckPos { get; set;}

		public CBTTaskWander(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskWander(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}