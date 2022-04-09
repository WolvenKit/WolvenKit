using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderTextureBlobSizeInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("width")] 
		public CUInt16 Width
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CUInt16 Height
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("depth")] 
		public CUInt16 Depth
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public rendRenderTextureBlobSizeInfo()
		{
			Depth = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
