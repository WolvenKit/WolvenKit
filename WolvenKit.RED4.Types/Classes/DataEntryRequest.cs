using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DataEntryRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("dataType")] 
		public CEnum<EGameSessionDataType> DataType
		{
			get => GetPropertyValue<CEnum<EGameSessionDataType>>();
			set => SetPropertyValue<CEnum<EGameSessionDataType>>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CVariant Data
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}
	}
}
