using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_playerKnowsSchematics : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("schematicsName")] 		public CName SchematicsName { get; set;}

		[Ordinal(2)] [RED("isFulfilled")] 		public CBool IsFulfilled { get; set;}

		[Ordinal(3)] [RED("listener")] 		public CHandle<W3QuestCond_playerKnowsSchematics_Listener> Listener { get; set;}

		public W3QuestCond_playerKnowsSchematics(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}