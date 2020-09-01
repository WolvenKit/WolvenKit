using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestHiResRealtimeDelayCondition : IQuestCondition
	{
		[Ordinal(0)] [RED("hours")] 		public CUInt32 Hours { get; set;}

		[Ordinal(0)] [RED("minutes")] 		public CUInt32 Minutes { get; set;}

		[Ordinal(0)] [RED("seconds")] 		public CUInt32 Seconds { get; set;}

		[Ordinal(0)] [RED("miliseconds")] 		public CUInt32 Miliseconds { get; set;}

		public CQuestHiResRealtimeDelayCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestHiResRealtimeDelayCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}