using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class KiroshiEffectorIsAimingStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("effector")] 
		public CWeakHandle<KiroshiHighlightEffector> Effector
		{
			get => GetPropertyValue<CWeakHandle<KiroshiHighlightEffector>>();
			set => SetPropertyValue<CWeakHandle<KiroshiHighlightEffector>>(value);
		}

		public KiroshiEffectorIsAimingStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
