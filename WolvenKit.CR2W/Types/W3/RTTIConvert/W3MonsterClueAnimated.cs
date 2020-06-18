using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MonsterClueAnimated : W3MonsterClue
	{
		[RED("animation")] 		public CEnum<EMonsterClueAnim> Animation { get; set;}

		[RED("witnessWholeAnimation")] 		public CBool WitnessWholeAnimation { get; set;}

		[RED("animStartEvent")] 		public CName AnimStartEvent { get; set;}

		[RED("animEndEvent")] 		public CName AnimEndEvent { get; set;}

		[RED("useAccuracyTest")] 		public CBool UseAccuracyTest { get; set;}

		[RED("accuracyError")] 		public CFloat AccuracyError { get; set;}

		[RED("stopAnimSoundEvent")] 		public CName StopAnimSoundEvent { get; set;}

		[RED("activatedByFact")] 		public CName ActivatedByFact { get; set;}

		public W3MonsterClueAnimated(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3MonsterClueAnimated(cr2w);

	}
}