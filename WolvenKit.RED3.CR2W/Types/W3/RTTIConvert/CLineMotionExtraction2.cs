using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CLineMotionExtraction2 : IMotionExtraction
	{
		[Ordinal(1)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(2)] [RED("frames", 2,0)] 		public CArray<CFloat> Frames { get; set;}

		[Ordinal(3)] [RED("deltaTimes", 2,0)] 		public CByteArray DeltaTimes { get; set;}

		[Ordinal(4)] [RED("flags")] 		public CUInt8 Flags { get; set;}

		public CLineMotionExtraction2(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}