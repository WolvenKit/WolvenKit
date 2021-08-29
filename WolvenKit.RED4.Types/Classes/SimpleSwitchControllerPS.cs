using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SimpleSwitchControllerPS : MasterControllerPS
	{
		private CEnum<ESwitchAction> _switchAction;
		private TweakDBID _nameForON;
		private TweakDBID _nameForOFF;

		[Ordinal(105)] 
		[RED("switchAction")] 
		public CEnum<ESwitchAction> SwitchAction
		{
			get => GetProperty(ref _switchAction);
			set => SetProperty(ref _switchAction, value);
		}

		[Ordinal(106)] 
		[RED("nameForON")] 
		public TweakDBID NameForON
		{
			get => GetProperty(ref _nameForON);
			set => SetProperty(ref _nameForON, value);
		}

		[Ordinal(107)] 
		[RED("nameForOFF")] 
		public TweakDBID NameForOFF
		{
			get => GetProperty(ref _nameForOFF);
			set => SetProperty(ref _nameForOFF, value);
		}
	}
}
