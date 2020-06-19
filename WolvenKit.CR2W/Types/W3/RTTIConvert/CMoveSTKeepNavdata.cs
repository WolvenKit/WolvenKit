using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTKeepNavdata : IMoveSteeringTask
	{
		[RED("slidingRate")] 		public CFloat SlidingRate { get; set;}

		[RED("maxSlidingRange")] 		public CFloat MaxSlidingRange { get; set;}

		[RED("maxTeleportationRange")] 		public CFloat MaxTeleportationRange { get; set;}

		[RED("applyStandardConditions")] 		public CBool ApplyStandardConditions { get; set;}

		public CMoveSTKeepNavdata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTKeepNavdata(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}