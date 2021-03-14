using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTResolveStucking : IMoveSteeringTask
	{
		[Ordinal(1)] [RED("stuckFramesThreshold")] 		public CUInt32 StuckFramesThreshold { get; set;}

		[Ordinal(2)] [RED("distanceThreshold")] 		public CFloat DistanceThreshold { get; set;}

		[Ordinal(3)] [RED("signalName")] 		public CName SignalName { get; set;}

		public CMoveSTResolveStucking(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTResolveStucking(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}