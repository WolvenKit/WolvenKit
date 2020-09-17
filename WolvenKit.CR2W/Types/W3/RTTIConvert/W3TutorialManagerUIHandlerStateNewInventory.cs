using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateNewInventory : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("TAB_CRAFTING")] 		public CName TAB_CRAFTING { get; set;}

		[Ordinal(2)] [RED("TAB_QUEST")] 		public CName TAB_QUEST { get; set;}

		[Ordinal(3)] [RED("TAB_MISC")] 		public CName TAB_MISC { get; set;}

		[Ordinal(4)] [RED("TAB_ALCHEMY")] 		public CName TAB_ALCHEMY { get; set;}

		[Ordinal(5)] [RED("TAB_WEAPONS")] 		public CName TAB_WEAPONS { get; set;}

		[Ordinal(6)] [RED("TOOLTIPS")] 		public CName TOOLTIPS { get; set;}

		[Ordinal(7)] [RED("PREVIEW")] 		public CName PREVIEW { get; set;}

		[Ordinal(8)] [RED("PREVIEW2")] 		public CName PREVIEW2 { get; set;}

		[Ordinal(9)] [RED("SORTING")] 		public CName SORTING { get; set;}

		[Ordinal(10)] [RED("GEEKPAGE")] 		public CName GEEKPAGE { get; set;}

		[Ordinal(11)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateNewInventory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateNewInventory(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}