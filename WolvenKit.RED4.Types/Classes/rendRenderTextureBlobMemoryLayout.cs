using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderTextureBlobMemoryLayout : RedBaseClass
	{
		private CUInt32 _rowPitch;
		private CUInt32 _slicePitch;

		[Ordinal(0)] 
		[RED("rowPitch")] 
		public CUInt32 RowPitch
		{
			get => GetProperty(ref _rowPitch);
			set => SetProperty(ref _rowPitch, value);
		}

		[Ordinal(1)] 
		[RED("slicePitch")] 
		public CUInt32 SlicePitch
		{
			get => GetProperty(ref _slicePitch);
			set => SetProperty(ref _slicePitch, value);
		}
	}
}
