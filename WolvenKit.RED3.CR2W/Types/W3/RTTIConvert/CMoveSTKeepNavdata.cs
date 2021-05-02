using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTKeepNavdata : IMoveSteeringTask
	{
		[Ordinal(1)] [RED("slidingRate")] 		public CFloat SlidingRate { get; set;}

		[Ordinal(2)] [RED("maxSlidingRange")] 		public CFloat MaxSlidingRange { get; set;}

		[Ordinal(3)] [RED("maxTeleportationRange")] 		public CFloat MaxTeleportationRange { get; set;}

		[Ordinal(4)] [RED("applyStandardConditions")] 		public CBool ApplyStandardConditions { get; set;}

		public CMoveSTKeepNavdata(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}