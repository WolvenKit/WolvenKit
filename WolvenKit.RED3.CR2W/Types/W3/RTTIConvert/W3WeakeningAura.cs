using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3WeakeningAura : W3Effect_Aura
	{
		[Ordinal(1)] [RED("usedVictim")] 		public CHandle<CActor> UsedVictim { get; set;}

		[Ordinal(2)] [RED("timeSinceLastApply")] 		public CFloat TimeSinceLastApply { get; set;}

		[Ordinal(3)] [RED("hasSelectedVictim")] 		public CBool HasSelectedVictim { get; set;}

		[Ordinal(4)] [RED("applicationDelay")] 		public CFloat ApplicationDelay { get; set;}

		[Ordinal(5)] [RED("targetCount")] 		public CInt32 TargetCount { get; set;}

		[Ordinal(6)] [RED("BUFF_DURATION")] 		public CFloat BUFF_DURATION { get; set;}

		public W3WeakeningAura(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}