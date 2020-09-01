using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateCharDevMutagens : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("DESCRIPTION")] 		public CName DESCRIPTION { get; set;}

		[Ordinal(2)] [RED("SELECT_TAB")] 		public CName SELECT_TAB { get; set;}

		[Ordinal(3)] [RED("EQUIP")] 		public CName EQUIP { get; set;}

		[Ordinal(4)] [RED("BONUSES")] 		public CName BONUSES { get; set;}

		[Ordinal(5)] [RED("MATCH_SKILL_COLOR")] 		public CName MATCH_SKILL_COLOR { get; set;}

		[Ordinal(6)] [RED("MULTIPLE_SKILLS")] 		public CName MULTIPLE_SKILLS { get; set;}

		[Ordinal(7)] [RED("WRONG_COLOR")] 		public CName WRONG_COLOR { get; set;}

		[Ordinal(8)] [RED("POTIONS")] 		public CName POTIONS { get; set;}

		[Ordinal(9)] [RED("MUTAGENS_JOURNAL")] 		public CName MUTAGENS_JOURNAL { get; set;}

		[Ordinal(10)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		[Ordinal(11)] [RED("savedEquippedSkills", 2,0)] 		public CArray<STutorialSavedSkill> SavedEquippedSkills { get; set;}

		public W3TutorialManagerUIHandlerStateCharDevMutagens(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateCharDevMutagens(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}