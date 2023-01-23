using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPhoneCallPhase_ConditionType : questIPhoneConditionType
	{
		[Ordinal(1)] 
		[RED("callPhase")] 
		public CEnum<questPhoneCallPhase> CallPhase
		{
			get => GetPropertyValue<CEnum<questPhoneCallPhase>>();
			set => SetPropertyValue<CEnum<questPhoneCallPhase>>(value);
		}

		public questPhoneCallPhase_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
