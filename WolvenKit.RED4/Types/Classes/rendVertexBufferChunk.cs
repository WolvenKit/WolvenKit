using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendVertexBufferChunk : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("vertexLayout")] 
		public GpuWrapApiVertexLayoutDesc VertexLayout
		{
			get => GetPropertyValue<GpuWrapApiVertexLayoutDesc>();
			set => SetPropertyValue<GpuWrapApiVertexLayoutDesc>(value);
		}

		[Ordinal(1)] 
		[RED("byteOffsets", 5)] 
		public CStatic<CUInt32> ByteOffsets
		{
			get => GetPropertyValue<CStatic<CUInt32>>();
			set => SetPropertyValue<CStatic<CUInt32>>(value);
		}

		public rendVertexBufferChunk()
		{
			VertexLayout = new() { Elements = new(0), SlotStrides = new(0), Hash = 4294967295 };
			ByteOffsets = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
