using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBoxComponent : CBoundedComponent
	{
		[RED("width")] 		public CFloat Width { get; set;}

		[RED("height")] 		public CFloat Height { get; set;}

		[RED("depth")] 		public CFloat Depth { get; set;}

		[RED("drawingColor")] 		public CColor DrawingColor { get; set;}

		public CBoxComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBoxComponent(cr2w);

	}
}