using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTimeDilation_World : questTimeDilation_NodeTypeParam
	{
		[Ordinal(0)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public CHandle<questTimeDilation_Operation> Operation
		{
			get => GetPropertyValue<CHandle<questTimeDilation_Operation>>();
			set => SetPropertyValue<CHandle<questTimeDilation_Operation>>(value);
		}

		public questTimeDilation_World()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
