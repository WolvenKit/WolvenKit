using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamGpuBuffer : meshMeshParameter
	{
		private CUInt32 _stride;
		private DataBuffer _data;

		[Ordinal(0)] 
		[RED("stride")] 
		public CUInt32 Stride
		{
			get => GetProperty(ref _stride);
			set => SetProperty(ref _stride, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
