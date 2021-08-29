using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshMaterialBuffer : RedBaseClass
	{
		private DataBuffer _rawData;
		private CArray<meshLocalMaterialHeader> _rawDataHeaders;

		[Ordinal(0)] 
		[RED("rawData")] 
		public DataBuffer RawData
		{
			get => GetProperty(ref _rawData);
			set => SetProperty(ref _rawData, value);
		}

		[Ordinal(1)] 
		[RED("rawDataHeaders")] 
		public CArray<meshLocalMaterialHeader> RawDataHeaders
		{
			get => GetProperty(ref _rawDataHeaders);
			set => SetProperty(ref _rawDataHeaders, value);
		}
	}
}
