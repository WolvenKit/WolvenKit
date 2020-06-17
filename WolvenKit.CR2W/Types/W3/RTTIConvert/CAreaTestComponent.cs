using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAreaTestComponent : CComponent
	{
		[RED("traceDistance")] 		public CFloat TraceDistance { get; set;}

		[RED("extents")] 		public Vector Extents { get; set;}

		[RED("searchRadius")] 		public CFloat SearchRadius { get; set;}

		public CAreaTestComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAreaTestComponent(cr2w);

	}
}