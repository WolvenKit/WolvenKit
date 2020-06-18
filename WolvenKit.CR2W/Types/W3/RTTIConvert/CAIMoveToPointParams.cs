using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMoveToPointParams : IAIActionParameters
	{
		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[RED("destinationPosition")] 		public Vector DestinationPosition { get; set;}

		[RED("destinationHeading")] 		public CFloat DestinationHeading { get; set;}

		[RED("maxIterationsNumber")] 		public CInt32 MaxIterationsNumber { get; set;}

		[RED("useTimeout")] 		public CBool UseTimeout { get; set;}

		[RED("timeoutValue")] 		public CFloat TimeoutValue { get; set;}

		public CAIMoveToPointParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIMoveToPointParams(cr2w);

	}
}