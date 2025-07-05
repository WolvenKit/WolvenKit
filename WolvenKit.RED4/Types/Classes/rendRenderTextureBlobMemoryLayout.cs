using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderTextureBlobMemoryLayout : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rowPitch")] 
		public CUInt32 RowPitch
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("slicePitch")] 
		public CUInt32 SlicePitch
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public rendRenderTextureBlobMemoryLayout()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
