using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeConditionRespondToMusicDefinition : CBehTreeNodeConditionDefinition
	{
		[Ordinal(0)] [RED("musicWaitTimeLimit")] 		public CBehTreeValFloat MusicWaitTimeLimit { get; set;}

		[Ordinal(0)] [RED("syncTimeOffset")] 		public CBehTreeValFloat SyncTimeOffset { get; set;}

		[Ordinal(0)] [RED("syncTypes")] 		public CBehTreeValString SyncTypes { get; set;}

		[Ordinal(0)] [RED("musicEventToTrigger")] 		public CBehTreeValString MusicEventToTrigger { get; set;}

		[Ordinal(0)] [RED("musicEventPreTriggerTime")] 		public CBehTreeValFloat MusicEventPreTriggerTime { get; set;}

		[Ordinal(0)] [RED("alwaysTriggerEvent")] 		public CBehTreeValBool AlwaysTriggerEvent { get; set;}

		public CBehTreeConditionRespondToMusicDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeConditionRespondToMusicDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}