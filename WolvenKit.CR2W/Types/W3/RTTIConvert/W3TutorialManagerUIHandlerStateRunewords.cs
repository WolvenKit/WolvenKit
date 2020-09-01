using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateRunewords : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[Ordinal(0)] [RED("("RUNEWORDS2")] 		public CName RUNEWORDS2 { get; set;}

		[Ordinal(0)] [RED("("ITEMS")] 		public CName ITEMS { get; set;}

		[Ordinal(0)] [RED("("ENCHANTS")] 		public CName ENCHANTS { get; set;}

		[Ordinal(0)] [RED("("ENCHANT_DESC")] 		public CName ENCHANT_DESC { get; set;}

		[Ordinal(0)] [RED("("LEVEL")] 		public CName LEVEL { get; set;}

		[Ordinal(0)] [RED("("UI")] 		public CName UI { get; set;}

		[Ordinal(0)] [RED("("isClosing")] 		public CBool IsClosing { get; set;}

		[Ordinal(0)] [RED("("LEFT_X")] 		public CFloat LEFT_X { get; set;}

		[Ordinal(0)] [RED("("LEFT_Y")] 		public CFloat LEFT_Y { get; set;}

		[Ordinal(0)] [RED("("RIGHT_X")] 		public CFloat RIGHT_X { get; set;}

		[Ordinal(0)] [RED("("RIGHT_Y")] 		public CFloat RIGHT_Y { get; set;}

		public W3TutorialManagerUIHandlerStateRunewords(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateRunewords(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}