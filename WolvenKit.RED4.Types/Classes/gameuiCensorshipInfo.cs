using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCensorshipInfo : RedBaseClass
	{
		private CEnum<CensorshipFlags> _censorFlag;
		private CEnum<gameuiCharacterCustomizationActionType> _censorFlagAction;

		[Ordinal(0)] 
		[RED("censorFlag")] 
		public CEnum<CensorshipFlags> CensorFlag
		{
			get => GetProperty(ref _censorFlag);
			set => SetProperty(ref _censorFlag, value);
		}

		[Ordinal(1)] 
		[RED("censorFlagAction")] 
		public CEnum<gameuiCharacterCustomizationActionType> CensorFlagAction
		{
			get => GetProperty(ref _censorFlagAction);
			set => SetProperty(ref _censorFlagAction, value);
		}
	}
}
