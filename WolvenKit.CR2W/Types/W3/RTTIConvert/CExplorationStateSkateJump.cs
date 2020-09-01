using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkateJump : CExplorationStateJump
	{
		[Ordinal(0)] [RED("skateGlobal")] 		public CHandle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

		[Ordinal(0)] [RED("attacked")] 		public CBool Attacked { get; set;}

		[Ordinal(0)] [RED("attacktimeMin")] 		public CFloat AttacktimeMin { get; set;}

		[Ordinal(0)] [RED("attackVertSpeedMin")] 		public CFloat AttackVertSpeedMin { get; set;}

		[Ordinal(0)] [RED("attackVertSpeedImpulse")] 		public CFloat AttackVertSpeedImpulse { get; set;}

		public CExplorationStateSkateJump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSkateJump(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}