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
		[Ordinal(1)] [RED("("OPEN_MAP")] 		public CName OPEN_MAP { get; set;}

		[Ordinal(2)] [RED("("DESCRIPTION")] 		public CName DESCRIPTION { get; set;}

		[Ordinal(3)] [RED("("JUMP_TO_OBJECTIVE")] 		public CName JUMP_TO_OBJECTIVE { get; set;}

		[Ordinal(4)] [RED("("NAVIGATE")] 		public CName NAVIGATE { get; set;}

		[Ordinal(5)] [RED("("QUEST_PINS")] 		public CName QUEST_PINS { get; set;}

		[Ordinal(6)] [RED("("OBJECTIVES")] 		public CName OBJECTIVES { get; set;}

		[Ordinal(7)] [RED("("AREA_MAP")] 		public CName AREA_MAP { get; set;}

		[Ordinal(8)] [RED("("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateMap(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}