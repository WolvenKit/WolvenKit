using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioDialogLineEventData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(1)] 
		[RED("context")] 
		public CEnum<locVoiceoverContext> Context
		{
			get => GetPropertyValue<CEnum<locVoiceoverContext>>();
			set => SetPropertyValue<CEnum<locVoiceoverContext>>(value);
		}

		[Ordinal(2)] 
		[RED("expression")] 
		public CEnum<locVoiceoverExpression> Expression
		{
			get => GetPropertyValue<CEnum<locVoiceoverExpression>>();
			set => SetPropertyValue<CEnum<locVoiceoverExpression>>(value);
		}

		[Ordinal(3)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isRewind")] 
		public CBool IsRewind
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isHolocall")] 
		public CBool IsHolocall
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("customVoEvent")] 
		public CName CustomVoEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("seekTime")] 
		public CFloat SeekTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("playbackSpeedParameter")] 
		public CFloat PlaybackSpeedParameter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioDialogLineEventData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
