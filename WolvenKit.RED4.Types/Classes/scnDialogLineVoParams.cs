using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnDialogLineVoParams : RedBaseClass
	{
		private CEnum<locVoiceoverContext> _voContext;
		private CEnum<locVoiceoverExpression> _voExpression;
		private CName _customVoEvent;
		private CBool _disableHeadMovement;
		private CBool _isHolocallSpeaker;
		private CBool _ignoreSpeakerIncapacitation;
		private CBool _alwaysUseBrainGender;

		[Ordinal(0)] 
		[RED("voContext")] 
		public CEnum<locVoiceoverContext> VoContext
		{
			get => GetProperty(ref _voContext);
			set => SetProperty(ref _voContext, value);
		}

		[Ordinal(1)] 
		[RED("voExpression")] 
		public CEnum<locVoiceoverExpression> VoExpression
		{
			get => GetProperty(ref _voExpression);
			set => SetProperty(ref _voExpression, value);
		}

		[Ordinal(2)] 
		[RED("customVoEvent")] 
		public CName CustomVoEvent
		{
			get => GetProperty(ref _customVoEvent);
			set => SetProperty(ref _customVoEvent, value);
		}

		[Ordinal(3)] 
		[RED("disableHeadMovement")] 
		public CBool DisableHeadMovement
		{
			get => GetProperty(ref _disableHeadMovement);
			set => SetProperty(ref _disableHeadMovement, value);
		}

		[Ordinal(4)] 
		[RED("isHolocallSpeaker")] 
		public CBool IsHolocallSpeaker
		{
			get => GetProperty(ref _isHolocallSpeaker);
			set => SetProperty(ref _isHolocallSpeaker, value);
		}

		[Ordinal(5)] 
		[RED("ignoreSpeakerIncapacitation")] 
		public CBool IgnoreSpeakerIncapacitation
		{
			get => GetProperty(ref _ignoreSpeakerIncapacitation);
			set => SetProperty(ref _ignoreSpeakerIncapacitation, value);
		}

		[Ordinal(6)] 
		[RED("alwaysUseBrainGender")] 
		public CBool AlwaysUseBrainGender
		{
			get => GetProperty(ref _alwaysUseBrainGender);
			set => SetProperty(ref _alwaysUseBrainGender, value);
		}
	}
}
