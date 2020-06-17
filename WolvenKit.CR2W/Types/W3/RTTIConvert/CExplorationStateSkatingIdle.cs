using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingIdle : CExplorationStateAbstract
	{
		[RED("turnSpeed")] 		public CFloat TurnSpeed { get; set;}

		[RED("turnStartTolerance")] 		public CFloat TurnStartTolerance { get; set;}

		[RED("hackCiri")] 		public CBool HackCiri { get; set;}

		[RED("behEventStart")] 		public CName BehEventStart { get; set;}

		[RED("behEventEnd")] 		public CName BehEventEnd { get; set;}

		public CExplorationStateSkatingIdle(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationStateSkatingIdle(cr2w);

	}
}