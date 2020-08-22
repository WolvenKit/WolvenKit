using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateContinentMap : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("TO_CONTINENT")] 		public CName TO_CONTINENT { get; set;}

		[RED("BACK_TO_HUB")] 		public CName BACK_TO_HUB { get; set;}

		[RED("TO_ANY_HUB")] 		public CName TO_ANY_HUB { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateContinentMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateContinentMap(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}