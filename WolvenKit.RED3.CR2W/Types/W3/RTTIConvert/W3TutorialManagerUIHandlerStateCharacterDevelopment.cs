using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateCharacterDevelopment : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("OPEN_CHAR_DEV")] 		public CName OPEN_CHAR_DEV { get; set;}

		[Ordinal(2)] [RED("LEVELING")] 		public CName LEVELING { get; set;}

		[Ordinal(3)] [RED("SKILLS")] 		public CName SKILLS { get; set;}

		[Ordinal(4)] [RED("BUY_SKILL")] 		public CName BUY_SKILL { get; set;}

		[Ordinal(5)] [RED("SKILL_EQUIPPING")] 		public CName SKILL_EQUIPPING { get; set;}

		[Ordinal(6)] [RED("EQUIP_SKILL")] 		public CName EQUIP_SKILL { get; set;}

		[Ordinal(7)] [RED("SKILL_UNEQUIPPING")] 		public CName SKILL_UNEQUIPPING { get; set;}

		[Ordinal(8)] [RED("GROUPS")] 		public CName GROUPS { get; set;}

		[Ordinal(9)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateCharacterDevelopment(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateCharacterDevelopment(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}