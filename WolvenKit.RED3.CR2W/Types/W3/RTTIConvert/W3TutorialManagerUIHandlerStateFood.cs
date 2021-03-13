using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateFood : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("SELECT_TAB")] 		public CName SELECT_TAB { get; set;}

		[Ordinal(2)] [RED("SELECT_FOOD")] 		public CName SELECT_FOOD { get; set;}

		[Ordinal(3)] [RED("EQUIP_FOOD")] 		public CName EQUIP_FOOD { get; set;}

		[Ordinal(4)] [RED("USAGE")] 		public CName USAGE { get; set;}

		[Ordinal(5)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateFood(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateFood(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}