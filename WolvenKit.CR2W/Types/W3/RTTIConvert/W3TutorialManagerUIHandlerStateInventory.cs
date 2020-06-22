using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateInventory : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("PAPERDOLL")] 		public CName PAPERDOLL { get; set;}

		[RED("BAG")] 		public CName BAG { get; set;}

		[RED("TABS")] 		public CName TABS { get; set;}

		[RED("STATS")] 		public CName STATS { get; set;}

		[RED("STATS_DETAILS")] 		public CName STATS_DETAILS { get; set;}

		[RED("EQUIPPING")] 		public CName EQUIPPING { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateInventory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateInventory(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}