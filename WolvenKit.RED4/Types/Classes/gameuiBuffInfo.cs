using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiBuffInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("buffID")] 
		public TweakDBID BuffID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("timeRemaining")] 
		public CFloat TimeRemaining
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiBuffInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
