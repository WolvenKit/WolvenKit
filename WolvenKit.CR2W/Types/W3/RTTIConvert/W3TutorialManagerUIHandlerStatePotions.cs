using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStatePotions : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("CAN_EQUIP")] 		public CName CAN_EQUIP { get; set;}

		[RED("SELECT_TAB")] 		public CName SELECT_TAB { get; set;}

		[RED("EQUIP_POTION")] 		public CName EQUIP_POTION { get; set;}

		[RED("EQUIP_POTION_THUNDERBOLT")] 		public CName EQUIP_POTION_THUNDERBOLT { get; set;}

		[RED("ON_EQUIPPED")] 		public CName ON_EQUIPPED { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		[RED("isForcedThunderbolt")] 		public CBool IsForcedThunderbolt { get; set;}

		[RED("skippingTabSelection")] 		public CBool SkippingTabSelection { get; set;}

		public W3TutorialManagerUIHandlerStatePotions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStatePotions(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}