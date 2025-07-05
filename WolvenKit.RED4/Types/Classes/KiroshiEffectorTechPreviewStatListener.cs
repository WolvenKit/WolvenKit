using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class KiroshiEffectorTechPreviewStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("effector")] 
		public CWeakHandle<KiroshiHighlightEffector> Effector
		{
			get => GetPropertyValue<CWeakHandle<KiroshiHighlightEffector>>();
			set => SetPropertyValue<CWeakHandle<KiroshiHighlightEffector>>(value);
		}

		public KiroshiEffectorTechPreviewStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
