using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnDialogLineEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("screenplayLineId")] 
		public scnscreenplayItemId ScreenplayLineId
		{
			get => GetPropertyValue<scnscreenplayItemId>();
			set => SetPropertyValue<scnscreenplayItemId>(value);
		}

		[Ordinal(7)] 
		[RED("voParams")] 
		public scnDialogLineVoParams VoParams
		{
			get => GetPropertyValue<scnDialogLineVoParams>();
			set => SetPropertyValue<scnDialogLineVoParams>(value);
		}

		[Ordinal(8)] 
		[RED("visualStyle")] 
		public CEnum<scnDialogLineVisualStyle> VisualStyle
		{
			get => GetPropertyValue<CEnum<scnDialogLineVisualStyle>>();
			set => SetPropertyValue<CEnum<scnDialogLineVisualStyle>>(value);
		}

		[Ordinal(9)] 
		[RED("additionalSpeakers")] 
		public scnAdditionalSpeakers AdditionalSpeakers
		{
			get => GetPropertyValue<scnAdditionalSpeakers>();
			set => SetPropertyValue<scnAdditionalSpeakers>(value);
		}

		public scnDialogLineEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			Duration = 1000;
			ScreenplayLineId = new scnscreenplayItemId { Id = 4294967040 };
			VoParams = new scnDialogLineVoParams();
			AdditionalSpeakers = new scnAdditionalSpeakers { Speakers = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
