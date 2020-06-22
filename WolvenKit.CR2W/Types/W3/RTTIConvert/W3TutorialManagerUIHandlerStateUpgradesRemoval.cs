using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateUpgradesRemoval : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("DESCRIPTION")] 		public CName DESCRIPTION { get; set;}

		[RED("ITEMS")] 		public CName ITEMS { get; set;}

		[RED("UPGRADES")] 		public CName UPGRADES { get; set;}

		[RED("COST")] 		public CName COST { get; set;}

		[RED("REMOVING")] 		public CName REMOVING { get; set;}

		[RED("POS_X")] 		public CFloat POS_X { get; set;}

		[RED("POS_Y")] 		public CFloat POS_Y { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateUpgradesRemoval(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateUpgradesRemoval(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}