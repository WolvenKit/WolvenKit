using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class STextureGroupSetup : RedBaseClass
	{
		private CEnum<GpuWrapApieTextureGroup> _group;
		private CEnum<ETextureRawFormat> _rawFormat;
		private CEnum<ETextureCompression> _compression;
		private CBool _isStreamable;
		private CBool _hasMipchain;
		private CBool _isGamma;
		private CUInt8 _platformMipBiasPC;
		private CUInt8 _platformMipBiasConsole;
		private CBool _allowTextureDowngrade;

		[Ordinal(0)] 
		[RED("group")] 
		public CEnum<GpuWrapApieTextureGroup> Group
		{
			get => GetProperty(ref _group);
			set => SetProperty(ref _group, value);
		}

		[Ordinal(1)] 
		[RED("rawFormat")] 
		public CEnum<ETextureRawFormat> RawFormat
		{
			get => GetProperty(ref _rawFormat);
			set => SetProperty(ref _rawFormat, value);
		}

		[Ordinal(2)] 
		[RED("compression")] 
		public CEnum<ETextureCompression> Compression
		{
			get => GetProperty(ref _compression);
			set => SetProperty(ref _compression, value);
		}

		[Ordinal(3)] 
		[RED("isStreamable")] 
		public CBool IsStreamable
		{
			get => GetProperty(ref _isStreamable);
			set => SetProperty(ref _isStreamable, value);
		}

		[Ordinal(4)] 
		[RED("hasMipchain")] 
		public CBool HasMipchain
		{
			get => GetProperty(ref _hasMipchain);
			set => SetProperty(ref _hasMipchain, value);
		}

		[Ordinal(5)] 
		[RED("isGamma")] 
		public CBool IsGamma
		{
			get => GetProperty(ref _isGamma);
			set => SetProperty(ref _isGamma, value);
		}

		[Ordinal(6)] 
		[RED("platformMipBiasPC")] 
		public CUInt8 PlatformMipBiasPC
		{
			get => GetProperty(ref _platformMipBiasPC);
			set => SetProperty(ref _platformMipBiasPC, value);
		}

		[Ordinal(7)] 
		[RED("platformMipBiasConsole")] 
		public CUInt8 PlatformMipBiasConsole
		{
			get => GetProperty(ref _platformMipBiasConsole);
			set => SetProperty(ref _platformMipBiasConsole, value);
		}

		[Ordinal(8)] 
		[RED("allowTextureDowngrade")] 
		public CBool AllowTextureDowngrade
		{
			get => GetProperty(ref _allowTextureDowngrade);
			set => SetProperty(ref _allowTextureDowngrade, value);
		}

		public STextureGroupSetup()
		{
			_group = new() { Value = Enums.GpuWrapApieTextureGroup.TEXG_Generic_Color };
			_rawFormat = new() { Value = Enums.ETextureRawFormat.TRF_TrueColor };
			_isStreamable = true;
			_hasMipchain = true;
			_allowTextureDowngrade = true;
		}
	}
}
