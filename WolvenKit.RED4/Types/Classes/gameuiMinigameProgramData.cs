using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinigameProgramData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("programName")] 
		public CName ProgramName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiMinigameProgramData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
