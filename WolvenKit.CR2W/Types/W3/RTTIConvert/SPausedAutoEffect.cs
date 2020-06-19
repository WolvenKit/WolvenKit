using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPausedAutoEffect : CVariable
	{
		[RED("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("sourceName")] 		public CName SourceName { get; set;}

		[RED("singleLock")] 		public CBool SingleLock { get; set;}

		[RED("useMaxDuration")] 		public CBool UseMaxDuration { get; set;}

		[RED("timeLeft")] 		public CFloat TimeLeft { get; set;}

		public SPausedAutoEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SPausedAutoEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}