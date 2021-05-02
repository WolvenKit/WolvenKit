using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MonsterClueAnimated : W3MonsterClue
	{
		[Ordinal(1)] [RED("animation")] 		public CEnum<EMonsterClueAnim> Animation { get; set;}

		[Ordinal(2)] [RED("witnessWholeAnimation")] 		public CBool WitnessWholeAnimation { get; set;}

		[Ordinal(3)] [RED("animStartEvent")] 		public CName AnimStartEvent { get; set;}

		[Ordinal(4)] [RED("animEndEvent")] 		public CName AnimEndEvent { get; set;}

		[Ordinal(5)] [RED("useAccuracyTest")] 		public CBool UseAccuracyTest { get; set;}

		[Ordinal(6)] [RED("accuracyError")] 		public CFloat AccuracyError { get; set;}

		[Ordinal(7)] [RED("stopAnimSoundEvent")] 		public CName StopAnimSoundEvent { get; set;}

		[Ordinal(8)] [RED("activatedByFact")] 		public CName ActivatedByFact { get; set;}

		[Ordinal(9)] [RED("spawnPosWasSaved")] 		public CBool SpawnPosWasSaved { get; set;}

		[Ordinal(10)] [RED("spawnPos")] 		public Vector SpawnPos { get; set;}

		[Ordinal(11)] [RED("spawnRot")] 		public EulerAngles SpawnRot { get; set;}

		[Ordinal(12)] [RED("animStarted")] 		public CBool AnimStarted { get; set;}

		public W3MonsterClueAnimated(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}