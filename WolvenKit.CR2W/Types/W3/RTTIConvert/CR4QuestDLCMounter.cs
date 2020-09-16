using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4QuestDLCMounter : IGameplayDLCMounter
	{
		[Ordinal(1)] [RED("quest")] 		public CHandle<CQuest> Quest { get; set;}

		[Ordinal(2)] [RED("taintFact")] 		public CName TaintFact { get; set;}

		[Ordinal(3)] [RED("sceneVoiceTagsTableFilePath")] 		public CString SceneVoiceTagsTableFilePath { get; set;}

		[Ordinal(4)] [RED("questLevelsFilePath")] 		public CString QuestLevelsFilePath { get; set;}

		public CR4QuestDLCMounter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4QuestDLCMounter(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}