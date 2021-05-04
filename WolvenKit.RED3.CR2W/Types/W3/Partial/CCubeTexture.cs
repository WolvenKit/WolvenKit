using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;
using WolvenKit.Common.Model;

namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CCubeTexture : CResource
	{
		[Ordinal(1)] [RED("targetFaceSize")] 		public CUInt32 TargetFaceSize { get; set;}

		[Ordinal(2)] [RED("strategy")] 		public CEnum<ECubeGenerationStrategy> Strategy { get; set;}

		[Ordinal(3)] [RED("compression")] 		public CEnum<ETextureCompression> Compression { get; set;}

		[Ordinal(4)] [RED("front")] 		public CubeFace Front { get; set;}

		[Ordinal(5)] [RED("back")] 		public CubeFace Back { get; set;}

		[Ordinal(6)] [RED("top")] 		public CubeFace Top { get; set;}

		[Ordinal(7)] [RED("bottom")] 		public CubeFace Bottom { get; set;}

		[Ordinal(8)] [RED("left")] 		public CubeFace Left { get; set;}

		[Ordinal(9)] [RED("right")] 		public CubeFace Right { get; set;}


	}
}
