using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectPostAction_Beam_RicochetPreview : gameEffectPostAction
	{
		private gameEffectPostAction_Beam_RicochetPreviewPreviewEffect _ricocheted;
		private gameEffectPostAction_Beam_RicochetPreviewPreviewEffect _fromMuzzle;

		[Ordinal(0)] 
		[RED("ricocheted")] 
		public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect Ricocheted
		{
			get => GetProperty(ref _ricocheted);
			set => SetProperty(ref _ricocheted, value);
		}

		[Ordinal(1)] 
		[RED("fromMuzzle")] 
		public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect FromMuzzle
		{
			get => GetProperty(ref _fromMuzzle);
			set => SetProperty(ref _fromMuzzle, value);
		}
	}
}
