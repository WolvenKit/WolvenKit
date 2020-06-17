using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMapPathDefinition : CVariable
	{
		[RED("tag")] 		public CName Tag { get; set;}

		[RED("lineWidth")] 		public CFloat LineWidth { get; set;}

		[RED("lineSegmentLength")] 		public CFloat LineSegmentLength { get; set;}

		[RED("color")] 		public CColor Color { get; set;}

		public SMapPathDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SMapPathDefinition(cr2w);

	}
}