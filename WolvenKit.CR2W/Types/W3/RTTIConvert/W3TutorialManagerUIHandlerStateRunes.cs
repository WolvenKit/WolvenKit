using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateRunes : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("SELECT")] 		public CName SELECT { get; set;}

		[RED("RUNE")] 		public CName RUNE { get; set;}

		[RED("SWORD")] 		public CName SWORD { get; set;}

		public W3TutorialManagerUIHandlerStateRunes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateRunes(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}