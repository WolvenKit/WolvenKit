using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingIdle : CExplorationStateAbstract
	{
		[Ordinal(1)] [RED("("skateGlobal")] 		public CHandle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

		[Ordinal(2)] [RED("("turnSpeed")] 		public CFloat TurnSpeed { get; set;}

		[Ordinal(3)] [RED("("turnStartTolerance")] 		public CFloat TurnStartTolerance { get; set;}

		[Ordinal(4)] [RED("("hackCiri")] 		public CBool HackCiri { get; set;}

		[Ordinal(5)] [RED("("behEventStart")] 		public CName BehEventStart { get; set;}

		[Ordinal(6)] [RED("("behEventEnd")] 		public CName BehEventEnd { get; set;}

		public CExplorationStateSkatingIdle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSkatingIdle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}