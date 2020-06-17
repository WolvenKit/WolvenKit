using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpotLightComponent : CLightComponent
	{
		[RED("innerAngle")] 		public CFloat InnerAngle { get; set;}

		[RED("outerAngle")] 		public CFloat OuterAngle { get; set;}

		[RED("softness")] 		public CFloat Softness { get; set;}

		[RED("projectionTexture")] 		public CHandle<CBitmapTexture> ProjectionTexture { get; set;}

		[RED("projectionTextureAngle")] 		public CFloat ProjectionTextureAngle { get; set;}

		[RED("projectionTexureUBias")] 		public CFloat ProjectionTexureUBias { get; set;}

		[RED("projectionTexureVBias")] 		public CFloat ProjectionTexureVBias { get; set;}

		public CSpotLightComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSpotLightComponent(cr2w);

	}
}