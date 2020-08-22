using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CCubeTexture : CResource
	{
		[RED("targetFaceSize")] 		public CUInt32 TargetFaceSize { get; set;}

		[RED("strategy")] 		public CEnum<ECubeGenerationStrategy> Strategy { get; set;}

		[RED("compression")] 		public CEnum<ETextureCompression> Compression { get; set;}

		[RED("front")] 		public CubeFace Front { get; set;}

		[RED("back")] 		public CubeFace Back { get; set;}

		[RED("top")] 		public CubeFace Top { get; set;}

		[RED("bottom")] 		public CubeFace Bottom { get; set;}

		[RED("left")] 		public CubeFace Left { get; set;}

		[RED("right")] 		public CubeFace Right { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCubeTexture(cr2w, parent, name);

	}
}