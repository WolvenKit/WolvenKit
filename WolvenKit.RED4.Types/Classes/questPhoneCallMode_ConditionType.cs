using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPhoneCallMode_ConditionType : questIPhoneConditionType
	{
		private CEnum<questPhoneCallMode> _callMode;

		[Ordinal(1)] 
		[RED("callMode")] 
		public CEnum<questPhoneCallMode> CallMode
		{
			get => GetProperty(ref _callMode);
			set => SetProperty(ref _callMode, value);
		}
	}
}
