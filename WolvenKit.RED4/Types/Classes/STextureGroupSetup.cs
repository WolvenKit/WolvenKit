using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class STextureGroupSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("group")] 
		public CEnum<GpuWrapApieTextureGroup> Group
		{
			get => GetPropertyValue<CEnum<GpuWrapApieTextureGroup>>();
			set => SetPropertyValue<CEnum<GpuWrapApieTextureGroup>>(value);
		}

		[Ordinal(1)] 
		[RED("rawFormat")] 
		public CEnum<ETextureRawFormat> RawFormat
		{
			get => GetPropertyValue<CEnum<ETextureRawFormat>>();
			set => SetPropertyValue<CEnum<ETextureRawFormat>>(value);
		}

		[Ordinal(2)] 
		[RED("compression")] 
		public CEnum<ETextureCompression> Compression
		{
			get => GetPropertyValue<CEnum<ETextureCompression>>();
			set => SetPropertyValue<CEnum<ETextureCompression>>(value);
		}

		[Ordinal(3)] 
		[RED("isStreamable")] 
		public CBool IsStreamable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("hasMipchain")] 
		public CBool HasMipchain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isGamma")] 
		public CBool IsGamma
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("platformMipBiasPC")] 
		public CUInt8 PlatformMipBiasPC
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(7)] 
		[RED("platformMipBiasConsole")] 
		public CUInt8 PlatformMipBiasConsole
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(8)] 
		[RED("allowTextureDowngrade")] 
		public CBool AllowTextureDowngrade
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public STextureGroupSetup()
		{
			Group = Enums.GpuWrapApieTextureGroup.TEXG_Generic_Color;
			RawFormat = Enums.ETextureRawFormat.TRF_TrueColor;
			IsStreamable = true;
			HasMipchain = true;
			AllowTextureDowngrade = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
