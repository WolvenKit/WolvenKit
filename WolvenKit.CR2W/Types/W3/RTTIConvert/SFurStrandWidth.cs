using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurStrandWidth : CVariable
	{
		[Ordinal(0)] [RED("("width")] 		public CFloat Width { get; set;}

		[Ordinal(0)] [RED("("widthRootScale")] 		public CFloat WidthRootScale { get; set;}

		[Ordinal(0)] [RED("("widthTipScale")] 		public CFloat WidthTipScale { get; set;}

		[Ordinal(0)] [RED("("rootWidthTex")] 		public CHandle<CBitmapTexture> RootWidthTex { get; set;}

		[Ordinal(0)] [RED("("rootWidthTexChannel")] 		public CEnum<EHairTextureChannel> RootWidthTexChannel { get; set;}

		[Ordinal(0)] [RED("("tipWidthTex")] 		public CHandle<CBitmapTexture> TipWidthTex { get; set;}

		[Ordinal(0)] [RED("("tipWidthTexChannel")] 		public CEnum<EHairTextureChannel> TipWidthTexChannel { get; set;}

		[Ordinal(0)] [RED("("widthNoise")] 		public CFloat WidthNoise { get; set;}

		public SFurStrandWidth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurStrandWidth(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}