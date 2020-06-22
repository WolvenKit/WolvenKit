using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSkeleton2SkeletonMapper : CObject
	{
		[RED("skeletonB")] 		public CHandle<CSkeleton> SkeletonB { get; set;}

		[RED("pelvisBoneName")] 		public CName PelvisBoneName { get; set;}

		[RED("motionScale")] 		public CFloat MotionScale { get; set;}

		[RED("mappingA2B", 2,0)] 		public CArray<CInt32> MappingA2B { get; set;}

		[RED("mappingB2A", 2,0)] 		public CArray<CInt32> MappingB2A { get; set;}

		[RED("skeletonsAreSimilar")] 		public CBool SkeletonsAreSimilar { get; set;}

		public CSkeleton2SkeletonMapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSkeleton2SkeletonMapper(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}