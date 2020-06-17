using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTResolveStucking : IMoveSteeringTask
	{
		[RED("stuckFramesThreshold")] 		public CUInt32 StuckFramesThreshold { get; set;}

		[RED("distanceThreshold")] 		public CFloat DistanceThreshold { get; set;}

		[RED("signalName")] 		public CName SignalName { get; set;}

		public CMoveSTResolveStucking(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CMoveSTResolveStucking(cr2w);

	}
}