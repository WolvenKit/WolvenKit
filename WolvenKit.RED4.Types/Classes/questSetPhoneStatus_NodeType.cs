using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetPhoneStatus_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<questPhoneStatus> Status
		{
			get => GetPropertyValue<CEnum<questPhoneStatus>>();
			set => SetPropertyValue<CEnum<questPhoneStatus>>(value);
		}

		[Ordinal(1)] 
		[RED("customStatus")] 
		public CName CustomStatus
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questSetPhoneStatus_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
