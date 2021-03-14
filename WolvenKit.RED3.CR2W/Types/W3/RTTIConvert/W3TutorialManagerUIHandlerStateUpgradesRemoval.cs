using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateUpgradesRemoval : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("DESCRIPTION")] 		public CName DESCRIPTION { get; set;}

		[Ordinal(2)] [RED("ITEMS")] 		public CName ITEMS { get; set;}

		[Ordinal(3)] [RED("UPGRADES")] 		public CName UPGRADES { get; set;}

		[Ordinal(4)] [RED("COST")] 		public CName COST { get; set;}

		[Ordinal(5)] [RED("REMOVING")] 		public CName REMOVING { get; set;}

		[Ordinal(6)] [RED("POS_X")] 		public CFloat POS_X { get; set;}

		[Ordinal(7)] [RED("POS_Y")] 		public CFloat POS_Y { get; set;}

		[Ordinal(8)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateUpgradesRemoval(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateUpgradesRemoval(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}