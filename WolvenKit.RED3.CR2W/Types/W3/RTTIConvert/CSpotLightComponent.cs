using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpotLightComponent : CLightComponent
	{
		[Ordinal(1)] [RED("innerAngle")] 		public CFloat InnerAngle { get; set;}

		[Ordinal(2)] [RED("outerAngle")] 		public CFloat OuterAngle { get; set;}

		[Ordinal(3)] [RED("softness")] 		public CFloat Softness { get; set;}

		[Ordinal(4)] [RED("projectionTexture")] 		public CHandle<CBitmapTexture> ProjectionTexture { get; set;}

		[Ordinal(5)] [RED("projectionTextureAngle")] 		public CFloat ProjectionTextureAngle { get; set;}

		[Ordinal(6)] [RED("projectionTexureUBias")] 		public CFloat ProjectionTexureUBias { get; set;}

		[Ordinal(7)] [RED("projectionTexureVBias")] 		public CFloat ProjectionTexureVBias { get; set;}

		public CSpotLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSpotLightComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}