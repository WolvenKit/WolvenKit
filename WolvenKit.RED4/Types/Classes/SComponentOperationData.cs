using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SComponentOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("operationType")] 
		public CEnum<EComponentOperation> OperationType
		{
			get => GetPropertyValue<CEnum<EComponentOperation>>();
			set => SetPropertyValue<CEnum<EComponentOperation>>(value);
		}

		public SComponentOperationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
