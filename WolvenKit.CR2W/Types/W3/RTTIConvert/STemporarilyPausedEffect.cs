using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class STemporarilyPausedEffect : CVariable
	{
		[Ordinal(1)] [RED("("buff")] 		public CHandle<CBaseGameplayEffect> Buff { get; set;}

		[Ordinal(2)] [RED("("timeLeft")] 		public CFloat TimeLeft { get; set;}

		[Ordinal(3)] [RED("("source")] 		public CName Source { get; set;}

		[Ordinal(4)] [RED("("singleLock")] 		public CBool SingleLock { get; set;}

		[Ordinal(5)] [RED("("useMaxDuration")] 		public CBool UseMaxDuration { get; set;}

		[Ordinal(6)] [RED("("duration")] 		public CFloat Duration { get; set;}

		public STemporarilyPausedEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new STemporarilyPausedEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}