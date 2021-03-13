using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateRunewords : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(1)] [RED("RUNEWORDS2")] 		public CName RUNEWORDS2 { get; set;}

		[Ordinal(2)] [RED("ITEMS")] 		public CName ITEMS { get; set;}

		[Ordinal(3)] [RED("ENCHANTS")] 		public CName ENCHANTS { get; set;}

		[Ordinal(4)] [RED("ENCHANT_DESC")] 		public CName ENCHANT_DESC { get; set;}

		[Ordinal(5)] [RED("LEVEL")] 		public CName LEVEL { get; set;}

		[Ordinal(6)] [RED("UI")] 		public CName UI { get; set;}

		[Ordinal(7)] [RED("isClosing")] 		public CBool IsClosing { get; set;}

		[Ordinal(8)] [RED("LEFT_X")] 		public CFloat LEFT_X { get; set;}

		[Ordinal(9)] [RED("LEFT_Y")] 		public CFloat LEFT_Y { get; set;}

		[Ordinal(10)] [RED("RIGHT_X")] 		public CFloat RIGHT_X { get; set;}

		[Ordinal(11)] [RED("RIGHT_Y")] 		public CFloat RIGHT_Y { get; set;}

		public W3TutorialManagerUIHandlerStateRunewords(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateRunewords(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}