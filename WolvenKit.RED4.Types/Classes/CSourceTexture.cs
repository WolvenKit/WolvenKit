using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CSourceTexture : ISerializable
	{
		[Ordinal(0)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("depth")] 
		public CUInt32 Depth
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("pitch")] 
		public CUInt32 Pitch
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("format")] 
		public CEnum<ETextureRawFormat> Format
		{
			get => GetPropertyValue<CEnum<ETextureRawFormat>>();
			set => SetPropertyValue<CEnum<ETextureRawFormat>>(value);
		}

		public CSourceTexture()
		{
			Depth = 1;
			Format = Enums.ETextureRawFormat.TRF_TrueColor;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
