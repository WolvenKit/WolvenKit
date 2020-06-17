using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationBufferBitwiseCompressedData : CVariable
	{
		[RED("dt")] 		public CFloat Dt { get; set;}

		[RED("compression")] 		public CInt8 Compression { get; set;}

		[RED("numFrames")] 		public CUInt16 NumFrames { get; set;}

		[RED("dataAddr")] 		public CUInt32 DataAddr { get; set;}

		[RED("dataAddrFallback")] 		public CUInt32 DataAddrFallback { get; set;}

		public SAnimationBufferBitwiseCompressedData(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SAnimationBufferBitwiseCompressedData(cr2w);

	}
}