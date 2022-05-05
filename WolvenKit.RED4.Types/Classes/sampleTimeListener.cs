using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleTimeListener : tickScriptTimeDilationListener
	{
		[Ordinal(0)] 
		[RED("myOwner")] 
		public CWeakHandle<sampleTimeDilatable> MyOwner
		{
			get => GetPropertyValue<CWeakHandle<sampleTimeDilatable>>();
			set => SetPropertyValue<CWeakHandle<sampleTimeDilatable>>(value);
		}

		public sampleTimeListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
