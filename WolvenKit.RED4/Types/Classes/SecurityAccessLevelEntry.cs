using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAccessLevelEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("keycard")] 
		public TweakDBID Keycard
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("password")] 
		public CName Password
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SecurityAccessLevelEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
