using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStripeComponent : CDrawableComponent
	{
		[RED("diffuseTexture")] 		public CHandle<CBitmapTexture> DiffuseTexture { get; set;}

		[RED("diffuseTexture2")] 		public CHandle<CBitmapTexture> DiffuseTexture2 { get; set;}

		[RED("normalTexture")] 		public CHandle<CBitmapTexture> NormalTexture { get; set;}

		[RED("normalTexture2")] 		public CHandle<CBitmapTexture> NormalTexture2 { get; set;}

		[RED("blendTexture")] 		public CHandle<CBitmapTexture> BlendTexture { get; set;}

		[RED("depthTexture")] 		public CHandle<CBitmapTexture> DepthTexture { get; set;}

		[RED("rotateTexture")] 		public CBool RotateTexture { get; set;}

		[RED("autoHideDistance")] 		public CFloat AutoHideDistance { get; set;}

		[RED("textureLength")] 		public CFloat TextureLength { get; set;}

		[RED("blendTextureLength")] 		public CFloat BlendTextureLength { get; set;}

		[RED("points", 2,0)] 		public CArray<SStripeControlPoint> Points { get; set;}

		[RED("width")] 		public CFloat Width { get; set;}

		[RED("alphaScale")] 		public CFloat AlphaScale { get; set;}

		[RED("endpointAlpha")] 		public CFloat EndpointAlpha { get; set;}

		[RED("stripeColor")] 		public CColor StripeColor { get; set;}

		[RED("density")] 		public CFloat Density { get; set;}

		[RED("projectToTerrain")] 		public CBool ProjectToTerrain { get; set;}

		[RED("exposedToNavigation")] 		public CBool ExposedToNavigation { get; set;}

		[RED("cookedVertices")] 		public DataBuffer CookedVertices { get; set;}

		[RED("cookedIndices")] 		public DataBuffer CookedIndices { get; set;}

		[RED("cookedVertexCount")] 		public CUInt32 CookedVertexCount { get; set;}

		[RED("cookedIndexCount")] 		public CUInt32 CookedIndexCount { get; set;}

		[RED("cookedBoundingBox")] 		public Box CookedBoundingBox { get; set;}

		public CStripeComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStripeComponent(cr2w);

	}
}