using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateStepLand : CExplorationStateAbstract
	{
		[Ordinal(1)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(2)] [RED("fallCancelled")] 		public CBool FallCancelled { get; set;}

		[Ordinal(3)] [RED("ended")] 		public CBool Ended { get; set;}

		[Ordinal(4)] [RED("timeSafetyEnd")] 		public CFloat TimeSafetyEnd { get; set;}

		[Ordinal(5)] [RED("directionToLand")] 		public CFloat DirectionToLand { get; set;}

		[Ordinal(6)] [RED("timeToChainJump")] 		public CFloat TimeToChainJump { get; set;}

		[Ordinal(7)] [RED("behAnimEnded")] 		public CName BehAnimEnded { get; set;}

		[Ordinal(8)] [RED("behLandRunS")] 		public CName BehLandRunS { get; set;}

		[Ordinal(9)] [RED("behAnimFall")] 		public CName BehAnimFall { get; set;}

		public CExplorationStateStepLand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateStepLand(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}