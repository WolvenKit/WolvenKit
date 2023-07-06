using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GpuWrapApiVertexLayoutDesc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("elements", 32)] 
		public CStatic<GpuWrapApiVertexPackingPackingElement> Elements
		{
			get => GetPropertyValue<CStatic<GpuWrapApiVertexPackingPackingElement>>();
			set => SetPropertyValue<CStatic<GpuWrapApiVertexPackingPackingElement>>(value);
		}

		[Ordinal(1)] 
		[RED("slotStrides", 8)] 
		public CStatic<CUInt8> SlotStrides
		{
			get => GetPropertyValue<CStatic<CUInt8>>();
			set => SetPropertyValue<CStatic<CUInt8>>(value);
		}

		[Ordinal(2)] 
		[RED("slotMask")] 
		public CUInt32 SlotMask
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("hash")] 
		public CUInt32 Hash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public GpuWrapApiVertexLayoutDesc()
		{
			Elements = new(0);
			SlotStrides = new(0);
			Hash = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
