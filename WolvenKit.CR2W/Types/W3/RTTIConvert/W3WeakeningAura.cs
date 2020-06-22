using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3WeakeningAura : W3Effect_Aura
	{
		[RED("usedVictim")] 		public CHandle<CActor> UsedVictim { get; set;}

		[RED("timeSinceLastApply")] 		public CFloat TimeSinceLastApply { get; set;}

		[RED("hasSelectedVictim")] 		public CBool HasSelectedVictim { get; set;}

		[RED("applicationDelay")] 		public CFloat ApplicationDelay { get; set;}

		[RED("targetCount")] 		public CInt32 TargetCount { get; set;}

		[RED("BUFF_DURATION")] 		public CFloat BUFF_DURATION { get; set;}

		public W3WeakeningAura(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3WeakeningAura(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}