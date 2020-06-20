using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMimicFaces : CResource
	{
		[RED("mimicSkeleton")] 		public CHandle<CSkeleton> MimicSkeleton { get; set;}

		[RED("mimicPoses", 2,0)] 		public CArray<CArray<EngineQsTransform>> MimicPoses { get; set;}

		[RED("mapping", 2,0)] 		public CArray<CInt32> Mapping { get; set;}

		[RED("neckIndex")] 		public CInt32 NeckIndex { get; set;}

		[RED("headIndex")] 		public CInt32 HeadIndex { get; set;}

		[RED("normalBlendAreas", 2,0)] 		public CArray<Vector> NormalBlendAreas { get; set;}

		public CMimicFaces(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMimicFaces(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}