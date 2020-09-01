using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationSkateLand : CExplorationStateAbstract
	{
		[Ordinal(1)] [RED("("skateGlobal")] 		public CHandle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

		[Ordinal(2)] [RED("("behLandCancel")] 		public CName BehLandCancel { get; set;}

		[Ordinal(3)] [RED("("timePrevToChain")] 		public CFloat TimePrevToChain { get; set;}

		[Ordinal(4)] [RED("("timeToChainJump")] 		public CFloat TimeToChainJump { get; set;}

		[Ordinal(5)] [RED("("timeSafetyEnd")] 		public CFloat TimeSafetyEnd { get; set;}

		[Ordinal(6)] [RED("("actionChained")] 		public CBool ActionChained { get; set;}

		public CExplorationSkateLand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationSkateLand(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}