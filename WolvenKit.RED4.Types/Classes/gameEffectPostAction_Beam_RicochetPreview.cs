using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectPostAction_Beam_RicochetPreview : gameEffectPostAction
	{
		[Ordinal(0)] 
		[RED("ricocheted")] 
		public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect Ricocheted
		{
			get => GetPropertyValue<gameEffectPostAction_Beam_RicochetPreviewPreviewEffect>();
			set => SetPropertyValue<gameEffectPostAction_Beam_RicochetPreviewPreviewEffect>(value);
		}

		[Ordinal(1)] 
		[RED("fromMuzzle")] 
		public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect FromMuzzle
		{
			get => GetPropertyValue<gameEffectPostAction_Beam_RicochetPreviewPreviewEffect>();
			set => SetPropertyValue<gameEffectPostAction_Beam_RicochetPreviewPreviewEffect>(value);
		}

		public gameEffectPostAction_Beam_RicochetPreview()
		{
			Ricocheted = new();
			FromMuzzle = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
