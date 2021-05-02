using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBoxComponent : CBoundedComponent
	{
		[Ordinal(1)] [RED("width")] 		public CFloat Width { get; set;}

		[Ordinal(2)] [RED("height")] 		public CFloat Height { get; set;}

		[Ordinal(3)] [RED("depth")] 		public CFloat Depth { get; set;}

		[Ordinal(4)] [RED("drawingColor")] 		public CColor DrawingColor { get; set;}

		public CBoxComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBoxComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}