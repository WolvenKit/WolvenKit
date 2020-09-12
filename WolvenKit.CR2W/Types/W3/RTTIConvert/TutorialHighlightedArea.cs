using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TutorialHighlightedArea : CVariable
	{
		[Ordinal(1)] [RED("x")] 		public CFloat X { get; set;}

		[Ordinal(2)] [RED("y")] 		public CFloat Y { get; set;}

		[Ordinal(3)] [RED("width")] 		public CFloat Width { get; set;}

		[Ordinal(4)] [RED("height")] 		public CFloat Height { get; set;}

		public TutorialHighlightedArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new TutorialHighlightedArea(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}