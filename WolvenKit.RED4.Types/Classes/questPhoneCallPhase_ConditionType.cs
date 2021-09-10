using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPhoneCallPhase_ConditionType : questIPhoneConditionType
	{
		[Ordinal(1)] 
		[RED("callPhase")] 
		public CEnum<questPhoneCallPhase> CallPhase
		{
			get => GetPropertyValue<CEnum<questPhoneCallPhase>>();
			set => SetPropertyValue<CEnum<questPhoneCallPhase>>(value);
		}
	}
}
