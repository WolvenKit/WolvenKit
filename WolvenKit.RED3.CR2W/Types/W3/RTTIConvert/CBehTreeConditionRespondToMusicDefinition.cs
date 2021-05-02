using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeConditionRespondToMusicDefinition : CBehTreeNodeConditionDefinition
	{
		[Ordinal(1)] [RED("musicWaitTimeLimit")] 		public CBehTreeValFloat MusicWaitTimeLimit { get; set;}

		[Ordinal(2)] [RED("syncTimeOffset")] 		public CBehTreeValFloat SyncTimeOffset { get; set;}

		[Ordinal(3)] [RED("syncTypes")] 		public CBehTreeValString SyncTypes { get; set;}

		[Ordinal(4)] [RED("musicEventToTrigger")] 		public CBehTreeValString MusicEventToTrigger { get; set;}

		[Ordinal(5)] [RED("musicEventPreTriggerTime")] 		public CBehTreeValFloat MusicEventPreTriggerTime { get; set;}

		[Ordinal(6)] [RED("alwaysTriggerEvent")] 		public CBehTreeValBool AlwaysTriggerEvent { get; set;}

		public CBehTreeConditionRespondToMusicDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}