using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class KiroshiHighlightEffectorCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("effector")] 
		public CHandle<KiroshiHighlightEffector> Effector
		{
			get => GetPropertyValue<CHandle<KiroshiHighlightEffector>>();
			set => SetPropertyValue<CHandle<KiroshiHighlightEffector>>(value);
		}

		public KiroshiHighlightEffectorCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
