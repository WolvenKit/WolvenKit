using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMapPathDefinition : CVariable
	{
		[Ordinal(1)] [RED("("tag")] 		public CName Tag { get; set;}

		[Ordinal(2)] [RED("("lineWidth")] 		public CFloat LineWidth { get; set;}

		[Ordinal(3)] [RED("("lineSegmentLength")] 		public CFloat LineSegmentLength { get; set;}

		[Ordinal(4)] [RED("("color")] 		public CColor Color { get; set;}

		public SMapPathDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMapPathDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}