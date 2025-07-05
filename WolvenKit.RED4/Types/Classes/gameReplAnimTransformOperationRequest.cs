using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameReplAnimTransformOperationRequest : gameReplAnimTransformRequestBase
	{
		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("operationType")] 
		public CUInt8 OperationType
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public gameReplAnimTransformOperationRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
