using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderTextureBlobPlacement : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("offset")] 
		public CUInt32 Offset
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("size")] 
		public CUInt32 Size
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public rendRenderTextureBlobPlacement()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
