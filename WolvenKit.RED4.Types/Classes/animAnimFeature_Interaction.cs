using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_Interaction : animAnimFeature
	{
		private CFloat _interactionDuration;
		private CInt32 _interactionStage;

		[Ordinal(0)] 
		[RED("interactionDuration")] 
		public CFloat InteractionDuration
		{
			get => GetProperty(ref _interactionDuration);
			set => SetProperty(ref _interactionDuration, value);
		}

		[Ordinal(1)] 
		[RED("interactionStage")] 
		public CInt32 InteractionStage
		{
			get => GetProperty(ref _interactionStage);
			set => SetProperty(ref _interactionStage, value);
		}
	}
}
