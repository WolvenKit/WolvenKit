using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateIngameMenuBestiary : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("OPEN_GLOSSARY")] 		public CName OPEN_GLOSSARY { get; set;}

		[RED("OPEN_GAME_MENU")] 		public CName OPEN_GAME_MENU { get; set;}

		public W3TutorialManagerUIHandlerStateIngameMenuBestiary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateIngameMenuBestiary(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}