using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateMap : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("OPEN_MAP")] 		public CName OPEN_MAP { get; set;}

		[RED("DESCRIPTION")] 		public CName DESCRIPTION { get; set;}

		[RED("JUMP_TO_OBJECTIVE")] 		public CName JUMP_TO_OBJECTIVE { get; set;}

		[RED("NAVIGATE")] 		public CName NAVIGATE { get; set;}

		[RED("QUEST_PINS")] 		public CName QUEST_PINS { get; set;}

		[RED("OBJECTIVES")] 		public CName OBJECTIVES { get; set;}

		[RED("AREA_MAP")] 		public CName AREA_MAP { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateMap(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}