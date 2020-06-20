using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IQuestCombatManagerBaseBlock : CQuestGraphBlock
	{
		[RED("npcTags")] 		public TagList NpcTags { get; set;}

		[RED("overrideGuardArea")] 		public CBool OverrideGuardArea { get; set;}

		[RED("guardAreaTag")] 		public CName GuardAreaTag { get; set;}

		[RED("pursuitAreaTag")] 		public CName PursuitAreaTag { get; set;}

		[RED("pursuitRange")] 		public CFloat PursuitRange { get; set;}

		public IQuestCombatManagerBaseBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new IQuestCombatManagerBaseBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}