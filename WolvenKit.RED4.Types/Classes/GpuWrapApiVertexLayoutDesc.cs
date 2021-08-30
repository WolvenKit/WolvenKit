using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GpuWrapApiVertexLayoutDesc : RedBaseClass
	{
		private CStatic<GpuWrapApiVertexPackingPackingElement> _elements;
		private CStatic<CUInt8> _slotStrides;
		private CUInt32 _slotMask;
		private CUInt32 _hash;

		[Ordinal(0)] 
		[RED("elements", 32)] 
		public CStatic<GpuWrapApiVertexPackingPackingElement> Elements
		{
			get => GetProperty(ref _elements);
			set => SetProperty(ref _elements, value);
		}

		[Ordinal(1)] 
		[RED("slotStrides", 8)] 
		public CStatic<CUInt8> SlotStrides
		{
			get => GetProperty(ref _slotStrides);
			set => SetProperty(ref _slotStrides, value);
		}

		[Ordinal(2)] 
		[RED("slotMask")] 
		public CUInt32 SlotMask
		{
			get => GetProperty(ref _slotMask);
			set => SetProperty(ref _slotMask, value);
		}

		[Ordinal(3)] 
		[RED("hash")] 
		public CUInt32 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		public GpuWrapApiVertexLayoutDesc()
		{
			_hash = 4294967295;
		}
	}
}
