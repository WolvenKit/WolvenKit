using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GpuWrapApiVertexPackingPackingElement : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<GpuWrapApiVertexPackingePackingType> Type
		{
			get => GetPropertyValue<CEnum<GpuWrapApiVertexPackingePackingType>>();
			set => SetPropertyValue<CEnum<GpuWrapApiVertexPackingePackingType>>(value);
		}

		[Ordinal(1)] 
		[RED("usage")] 
		public CEnum<GpuWrapApiVertexPackingePackingUsage> Usage
		{
			get => GetPropertyValue<CEnum<GpuWrapApiVertexPackingePackingUsage>>();
			set => SetPropertyValue<CEnum<GpuWrapApiVertexPackingePackingUsage>>(value);
		}

		[Ordinal(2)] 
		[RED("usageIndex")] 
		public CUInt8 UsageIndex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(3)] 
		[RED("streamIndex")] 
		public CUInt8 StreamIndex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(4)] 
		[RED("streamType")] 
		public CEnum<GpuWrapApiVertexPackingEStreamType> StreamType
		{
			get => GetPropertyValue<CEnum<GpuWrapApiVertexPackingEStreamType>>();
			set => SetPropertyValue<CEnum<GpuWrapApiVertexPackingEStreamType>>(value);
		}

		public GpuWrapApiVertexPackingPackingElement()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
