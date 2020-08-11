using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateCharacterDevelopment : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("OPEN_CHAR_DEV")] 		public CName OPEN_CHAR_DEV { get; set;}

		[RED("LEVELING")] 		public CName LEVELING { get; set;}

		[RED("SKILLS")] 		public CName SKILLS { get; set;}

		[RED("BUY_SKILL")] 		public CName BUY_SKILL { get; set;}

		[RED("SKILL_EQUIPPING")] 		public CName SKILL_EQUIPPING { get; set;}

		[RED("EQUIP_SKILL")] 		public CName EQUIP_SKILL { get; set;}

		[RED("SKILL_UNEQUIPPING")] 		public CName SKILL_UNEQUIPPING { get; set;}

		[RED("GROUPS")] 		public CName GROUPS { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateCharacterDevelopment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateCharacterDevelopment(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}