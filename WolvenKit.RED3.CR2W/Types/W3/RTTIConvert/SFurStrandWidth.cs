using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurStrandWidth : CVariable
	{
		[Ordinal(1)] [RED("width")] 		public CFloat Width { get; set;}

		[Ordinal(2)] [RED("widthRootScale")] 		public CFloat WidthRootScale { get; set;}

		[Ordinal(3)] [RED("widthTipScale")] 		public CFloat WidthTipScale { get; set;}

		[Ordinal(4)] [RED("rootWidthTex")] 		public CHandle<CBitmapTexture> RootWidthTex { get; set;}

		[Ordinal(5)] [RED("rootWidthTexChannel")] 		public CEnum<EHairTextureChannel> RootWidthTexChannel { get; set;}

		[Ordinal(6)] [RED("tipWidthTex")] 		public CHandle<CBitmapTexture> TipWidthTex { get; set;}

		[Ordinal(7)] [RED("tipWidthTexChannel")] 		public CEnum<EHairTextureChannel> TipWidthTexChannel { get; set;}

		[Ordinal(8)] [RED("widthNoise")] 		public CFloat WidthNoise { get; set;}

		public SFurStrandWidth(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}