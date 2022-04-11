using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPhoneCallMode_ConditionType : questIPhoneConditionType
	{
		[Ordinal(1)] 
		[RED("callMode")] 
		public CEnum<questPhoneCallMode> CallMode
		{
			get => GetPropertyValue<CEnum<questPhoneCallMode>>();
			set => SetPropertyValue<CEnum<questPhoneCallMode>>(value);
		}
	}
}
