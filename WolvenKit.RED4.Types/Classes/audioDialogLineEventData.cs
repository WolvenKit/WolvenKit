using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioDialogLineEventData : RedBaseClass
	{
		private CRUID _stringId;
		private CEnum<locVoiceoverContext> _context;
		private CEnum<locVoiceoverExpression> _expression;
		private CBool _isPlayer;
		private CBool _isRewind;
		private CBool _isHolocall;
		private CName _customVoEvent;
		private CFloat _seekTime;
		private CFloat _playbackSpeedParameter;

		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetProperty(ref _stringId);
			set => SetProperty(ref _stringId, value);
		}

		[Ordinal(1)] 
		[RED("context")] 
		public CEnum<locVoiceoverContext> Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}

		[Ordinal(2)] 
		[RED("expression")] 
		public CEnum<locVoiceoverExpression> Expression
		{
			get => GetProperty(ref _expression);
			set => SetProperty(ref _expression, value);
		}

		[Ordinal(3)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(4)] 
		[RED("isRewind")] 
		public CBool IsRewind
		{
			get => GetProperty(ref _isRewind);
			set => SetProperty(ref _isRewind, value);
		}

		[Ordinal(5)] 
		[RED("isHolocall")] 
		public CBool IsHolocall
		{
			get => GetProperty(ref _isHolocall);
			set => SetProperty(ref _isHolocall, value);
		}

		[Ordinal(6)] 
		[RED("customVoEvent")] 
		public CName CustomVoEvent
		{
			get => GetProperty(ref _customVoEvent);
			set => SetProperty(ref _customVoEvent, value);
		}

		[Ordinal(7)] 
		[RED("seekTime")] 
		public CFloat SeekTime
		{
			get => GetProperty(ref _seekTime);
			set => SetProperty(ref _seekTime, value);
		}

		[Ordinal(8)] 
		[RED("playbackSpeedParameter")] 
		public CFloat PlaybackSpeedParameter
		{
			get => GetProperty(ref _playbackSpeedParameter);
			set => SetProperty(ref _playbackSpeedParameter, value);
		}
	}
}
