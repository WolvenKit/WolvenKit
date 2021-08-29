using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPhoneCallPhase_ConditionType : questIPhoneConditionType
	{
		private CEnum<questPhoneCallPhase> _callPhase;

		[Ordinal(1)] 
		[RED("callPhase")] 
		public CEnum<questPhoneCallPhase> CallPhase
		{
			get => GetProperty(ref _callPhase);
			set => SetProperty(ref _callPhase, value);
		}
	}
}
