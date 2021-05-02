using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSwarmVictim : CVariable
	{
		[Ordinal(1)] [RED("actor")] 		public CHandle<CActor> Actor { get; set;}

		[Ordinal(2)] [RED("timeInSwarm")] 		public CFloat TimeInSwarm { get; set;}

		[Ordinal(3)] [RED("inTrigger")] 		public CBool InTrigger { get; set;}

		public SSwarmVictim(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}