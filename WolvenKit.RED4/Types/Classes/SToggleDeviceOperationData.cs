using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SToggleDeviceOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("operationName")] 
		public CName OperationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SToggleDeviceOperationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
