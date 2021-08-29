using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DataEntryRequest : gameScriptableSystemRequest
	{
		private CEnum<EGameSessionDataType> _dataType;
		private CVariant _data;

		[Ordinal(0)] 
		[RED("dataType")] 
		public CEnum<EGameSessionDataType> DataType
		{
			get => GetProperty(ref _dataType);
			set => SetProperty(ref _dataType, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CVariant Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
