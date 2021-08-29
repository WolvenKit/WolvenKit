using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderTextureBlobPlacement : RedBaseClass
	{
		private CUInt32 _offset;
		private CUInt32 _size;

		[Ordinal(0)] 
		[RED("offset")] 
		public CUInt32 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(1)] 
		[RED("size")] 
		public CUInt32 Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}
	}
}
