using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandler : CObject
	{
		[Ordinal(1)] [RED("listeners", 2,0)] 		public CArray<SUITutorial> Listeners { get; set;}

		[Ordinal(2)] [RED("lastOpenedMenu")] 		public CName LastOpenedMenu { get; set;}

		[Ordinal(3)] [RED("isMenuOpened")] 		public CBool IsMenuOpened { get; set;}

		[Ordinal(4)] [RED("postponedUnregisteredMenu")] 		public CName PostponedUnregisteredMenu { get; set;}

		public W3TutorialManagerUIHandler(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandler(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}