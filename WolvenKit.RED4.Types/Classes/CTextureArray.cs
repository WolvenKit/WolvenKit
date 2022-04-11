using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CTextureArray : ITexture
	{
		[Ordinal(1)] 
		[RED("setup")] 
		public STextureGroupSetup Setup
		{
			get => GetPropertyValue<STextureGroupSetup>();
			set => SetPropertyValue<STextureGroupSetup>(value);
		}

		[Ordinal(2)] 
		[RED("renderResourceBlob")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlob
		{
			get => GetPropertyValue<CHandle<IRenderResourceBlob>>();
			set => SetPropertyValue<CHandle<IRenderResourceBlob>>(value);
		}

		[Ordinal(3)] 
		[RED("renderTextureResource")] 
		public rendRenderTextureResource RenderTextureResource
		{
			get => GetPropertyValue<rendRenderTextureResource>();
			set => SetPropertyValue<rendRenderTextureResource>(value);
		}

		public CTextureArray()
		{
			Setup = new() { Group = Enums.GpuWrapApieTextureGroup.TEXG_Generic_Color, RawFormat = Enums.ETextureRawFormat.TRF_TrueColor, IsStreamable = true, HasMipchain = true, AllowTextureDowngrade = true };
			RenderTextureResource = new();
		}
	}
}
