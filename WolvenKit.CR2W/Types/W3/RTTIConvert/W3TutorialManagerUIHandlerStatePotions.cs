using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStatePotions : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("CAN_EQUIP")] 		public CName CAN_EQUIP { get; set;}

		[Ordinal(2)] [RED("SELECT_TAB")] 		public CName SELECT_TAB { get; set;}

		[Ordinal(3)] [RED("EQUIP_POTION")] 		public CName EQUIP_POTION { get; set;}

		[Ordinal(4)] [RED("EQUIP_POTION_THUNDERBOLT")] 		public CName EQUIP_POTION_THUNDERBOLT { get; set;}

		[Ordinal(5)] [RED("ON_EQUIPPED")] 		public CName ON_EQUIPPED { get; set;}

		[Ordinal(6)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		[Ordinal(7)] [RED("isForcedThunderbolt")] 		public CBool IsForcedThunderbolt { get; set;}

		[Ordinal(8)] [RED("skippingTabSelection")] 		public CBool SkippingTabSelection { get; set;}

		public W3TutorialManagerUIHandlerStatePotions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStatePotions(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}