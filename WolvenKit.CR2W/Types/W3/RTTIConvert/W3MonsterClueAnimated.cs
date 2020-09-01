using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MonsterClueAnimated : W3MonsterClue
	{
		[Ordinal(0)] [RED("("animation")] 		public CEnum<EMonsterClueAnim> Animation { get; set;}

		[Ordinal(0)] [RED("("witnessWholeAnimation")] 		public CBool WitnessWholeAnimation { get; set;}

		[Ordinal(0)] [RED("("animStartEvent")] 		public CName AnimStartEvent { get; set;}

		[Ordinal(0)] [RED("("animEndEvent")] 		public CName AnimEndEvent { get; set;}

		[Ordinal(0)] [RED("("useAccuracyTest")] 		public CBool UseAccuracyTest { get; set;}

		[Ordinal(0)] [RED("("accuracyError")] 		public CFloat AccuracyError { get; set;}

		[Ordinal(0)] [RED("("stopAnimSoundEvent")] 		public CName StopAnimSoundEvent { get; set;}

		[Ordinal(0)] [RED("("activatedByFact")] 		public CName ActivatedByFact { get; set;}

		[Ordinal(0)] [RED("("spawnPosWasSaved")] 		public CBool SpawnPosWasSaved { get; set;}

		[Ordinal(0)] [RED("("spawnPos")] 		public Vector SpawnPos { get; set;}

		[Ordinal(0)] [RED("("spawnRot")] 		public EulerAngles SpawnRot { get; set;}

		[Ordinal(0)] [RED("("animStarted")] 		public CBool AnimStarted { get; set;}

		public W3MonsterClueAnimated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MonsterClueAnimated(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}