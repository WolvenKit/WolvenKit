using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateFood : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("SELECT_TAB")] 		public CName SELECT_TAB { get; set;}

		[RED("SELECT_FOOD")] 		public CName SELECT_FOOD { get; set;}

		[RED("EQUIP_FOOD")] 		public CName EQUIP_FOOD { get; set;}

		[RED("USAGE")] 		public CName USAGE { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateFood(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateFood(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}