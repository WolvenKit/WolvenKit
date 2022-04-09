using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSideScrollerMiniGameStateAdvanced : IScriptable
	{
		[Ordinal(0)] 
		[RED("opertyMaxScore")] 
		public CName OpertyMaxScore
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("opertyCurrentLives")] 
		public CName OpertyCurrentLives
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("opertyCurrentScore")] 
		public CName OpertyCurrentScore
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("PropertyChanged")] 
		public gameuiGameStatePropertyChangedCallback PropertyChanged_
		{
			get => GetPropertyValue<gameuiGameStatePropertyChangedCallback>();
			set => SetPropertyValue<gameuiGameStatePropertyChangedCallback>(value);
		}

		public gameuiSideScrollerMiniGameStateAdvanced()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
