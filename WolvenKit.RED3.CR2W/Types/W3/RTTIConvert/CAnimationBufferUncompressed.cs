using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimationBufferUncompressed : IAnimationBuffer
	{
		[Ordinal(1)] [RED("numFrames")] 		public CUInt32 NumFrames { get; set;}

		[Ordinal(2)] [RED("numBones")] 		public CUInt32 NumBones { get; set;}

		[Ordinal(3)] [RED("numTracks")] 		public CUInt32 NumTracks { get; set;}

		[Ordinal(4)] [RED("numDynamicTracks")] 		public CUInt32 NumDynamicTracks { get; set;}

		[Ordinal(5)] [RED("hasRefIKBones")] 		public CBool HasRefIKBones { get; set;}

		public CAnimationBufferUncompressed(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimationBufferUncompressed(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}