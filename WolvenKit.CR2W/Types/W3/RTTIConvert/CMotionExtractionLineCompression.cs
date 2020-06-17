using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMotionExtractionLineCompression : IMotionExtractionCompression
	{
		[RED("eps")] 		public CFloat Eps { get; set;}

		[RED("minKnots")] 		public CUInt32 MinKnots { get; set;}

		public CMotionExtractionLineCompression(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CMotionExtractionLineCompression(cr2w);

	}
}