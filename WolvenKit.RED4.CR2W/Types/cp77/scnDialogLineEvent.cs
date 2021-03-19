using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDialogLineEvent : scnSceneEvent
	{
		private scnscreenplayItemId _screenplayLineId;
		private scnDialogLineVoParams _voParams;
		private CEnum<scnDialogLineVisualStyle> _visualStyle;
		private scnAdditionalSpeakers _additionalSpeakers;

		[Ordinal(6)] 
		[RED("screenplayLineId")] 
		public scnscreenplayItemId ScreenplayLineId
		{
			get => GetProperty(ref _screenplayLineId);
			set => SetProperty(ref _screenplayLineId, value);
		}

		[Ordinal(7)] 
		[RED("voParams")] 
		public scnDialogLineVoParams VoParams
		{
			get => GetProperty(ref _voParams);
			set => SetProperty(ref _voParams, value);
		}

		[Ordinal(8)] 
		[RED("visualStyle")] 
		public CEnum<scnDialogLineVisualStyle> VisualStyle
		{
			get => GetProperty(ref _visualStyle);
			set => SetProperty(ref _visualStyle, value);
		}

		[Ordinal(9)] 
		[RED("additionalSpeakers")] 
		public scnAdditionalSpeakers AdditionalSpeakers
		{
			get => GetProperty(ref _additionalSpeakers);
			set => SetProperty(ref _additionalSpeakers, value);
		}

		public scnDialogLineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
