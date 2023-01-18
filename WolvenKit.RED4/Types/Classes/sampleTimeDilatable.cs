using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleTimeDilatable : gameTimeDilatable
	{
		[Ordinal(35)] 
		[RED("listener")] 
		public CHandle<sampleTimeListener> Listener
		{
			get => GetPropertyValue<CHandle<sampleTimeListener>>();
			set => SetPropertyValue<CHandle<sampleTimeListener>>(value);
		}

		public sampleTimeDilatable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
