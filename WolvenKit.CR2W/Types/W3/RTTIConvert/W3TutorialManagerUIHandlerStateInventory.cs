using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateInventory : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("PAPERDOLL")] 		public CName PAPERDOLL { get; set;}

		[Ordinal(2)] [RED("BAG")] 		public CName BAG { get; set;}

		[Ordinal(3)] [RED("TABS")] 		public CName TABS { get; set;}

		[Ordinal(4)] [RED("STATS")] 		public CName STATS { get; set;}

		[Ordinal(5)] [RED("STATS_DETAILS")] 		public CName STATS_DETAILS { get; set;}

		[Ordinal(6)] [RED("EQUIPPING")] 		public CName EQUIPPING { get; set;}

		[Ordinal(7)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateInventory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateInventory(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}