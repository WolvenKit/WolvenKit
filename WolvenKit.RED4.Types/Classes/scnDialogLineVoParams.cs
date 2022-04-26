using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnDialogLineVoParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("voContext")] 
		public CEnum<locVoiceoverContext> VoContext
		{
			get => GetPropertyValue<CEnum<locVoiceoverContext>>();
			set => SetPropertyValue<CEnum<locVoiceoverContext>>(value);
		}

		[Ordinal(1)] 
		[RED("voExpression")] 
		public CEnum<locVoiceoverExpression> VoExpression
		{
			get => GetPropertyValue<CEnum<locVoiceoverExpression>>();
			set => SetPropertyValue<CEnum<locVoiceoverExpression>>(value);
		}

		[Ordinal(2)] 
		[RED("customVoEvent")] 
		public CName CustomVoEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("disableHeadMovement")] 
		public CBool DisableHeadMovement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isHolocallSpeaker")] 
		public CBool IsHolocallSpeaker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("ignoreSpeakerIncapacitation")] 
		public CBool IgnoreSpeakerIncapacitation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("alwaysUseBrainGender")] 
		public CBool AlwaysUseBrainGender
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnDialogLineVoParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
