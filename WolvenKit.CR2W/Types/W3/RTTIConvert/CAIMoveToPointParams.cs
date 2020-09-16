using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMoveToPointParams : IAIActionParameters
	{
		[Ordinal(1)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(2)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(3)] [RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(4)] [RED("destinationPosition")] 		public Vector DestinationPosition { get; set;}

		[Ordinal(5)] [RED("destinationHeading")] 		public CFloat DestinationHeading { get; set;}

		[Ordinal(6)] [RED("maxIterationsNumber")] 		public CInt32 MaxIterationsNumber { get; set;}

		[Ordinal(7)] [RED("useTimeout")] 		public CBool UseTimeout { get; set;}

		[Ordinal(8)] [RED("timeoutValue")] 		public CFloat TimeoutValue { get; set;}

		public CAIMoveToPointParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMoveToPointParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}