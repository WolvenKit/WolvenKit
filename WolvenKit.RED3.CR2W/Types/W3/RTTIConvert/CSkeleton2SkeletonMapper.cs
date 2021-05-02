using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSkeleton2SkeletonMapper : CObject
	{
		[Ordinal(1)] [RED("skeletonB")] 		public CHandle<CSkeleton> SkeletonB { get; set;}

		[Ordinal(2)] [RED("pelvisBoneName")] 		public CName PelvisBoneName { get; set;}

		[Ordinal(3)] [RED("motionScale")] 		public CFloat MotionScale { get; set;}

		[Ordinal(4)] [RED("mappingA2B", 2,0)] 		public CArray<CInt32> MappingA2B { get; set;}

		[Ordinal(5)] [RED("mappingB2A", 2,0)] 		public CArray<CInt32> MappingB2A { get; set;}

		[Ordinal(6)] [RED("skeletonsAreSimilar")] 		public CBool SkeletonsAreSimilar { get; set;}

		public CSkeleton2SkeletonMapper(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSkeleton2SkeletonMapper(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}