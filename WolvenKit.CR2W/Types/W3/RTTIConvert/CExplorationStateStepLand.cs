using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateStepLand : CExplorationStateAbstract
	{
		[RED("timeSafetyEnd")] 		public CFloat TimeSafetyEnd { get; set;}

		[RED("timeToChainJump")] 		public CFloat TimeToChainJump { get; set;}

		[RED("behAnimEnded")] 		public CName BehAnimEnded { get; set;}

		[RED("behLandRunS")] 		public CName BehLandRunS { get; set;}

		[RED("behAnimFall")] 		public CName BehAnimFall { get; set;}

		public CExplorationStateStepLand(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationStateStepLand(cr2w);

	}
}