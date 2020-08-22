using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateNewInventory : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("TAB_CRAFTING")] 		public CName TAB_CRAFTING { get; set;}

		[RED("TAB_QUEST")] 		public CName TAB_QUEST { get; set;}

		[RED("TAB_MISC")] 		public CName TAB_MISC { get; set;}

		[RED("TAB_ALCHEMY")] 		public CName TAB_ALCHEMY { get; set;}

		[RED("TAB_WEAPONS")] 		public CName TAB_WEAPONS { get; set;}

		[RED("TOOLTIPS")] 		public CName TOOLTIPS { get; set;}

		[RED("PREVIEW")] 		public CName PREVIEW { get; set;}

		[RED("PREVIEW2")] 		public CName PREVIEW2 { get; set;}

		[RED("SORTING")] 		public CName SORTING { get; set;}

		[RED("GEEKPAGE")] 		public CName GEEKPAGE { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateNewInventory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateNewInventory(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}