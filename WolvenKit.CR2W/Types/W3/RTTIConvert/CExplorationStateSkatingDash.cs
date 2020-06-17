using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingDash : CExplorationStateAbstract
	{
		[RED("impulse")] 		public CFloat Impulse { get; set;}

		[RED("timeMax")] 		public CFloat TimeMax { get; set;}

		[RED("timeToChainMin")] 		public CFloat TimeToChainMin { get; set;}

		[RED("sharpTurnSpeed")] 		public CFloat SharpTurnSpeed { get; set;}

		[RED("holdTurnSpeed")] 		public CFloat HoldTurnSpeed { get; set;}

		[RED("sharpTurnTime")] 		public CFloat SharpTurnTime { get; set;}

		[RED("behAttackEvent")] 		public CName BehAttackEvent { get; set;}

		[RED("behLeftFootParam")] 		public CName BehLeftFootParam { get; set;}

		[RED("behEventEnd")] 		public CName BehEventEnd { get; set;}

		public CExplorationStateSkatingDash(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationStateSkatingDash(cr2w);

	}
}