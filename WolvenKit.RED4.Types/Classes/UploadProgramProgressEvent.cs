using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UploadProgramProgressEvent : redEvent
	{
		private CEnum<EUploadProgramState> _state;
		private CEnum<EProgressBarType> _progressBarType;
		private CEnum<EProgressBarContext> _progressBarContext;
		private CFloat _duration;
		private CWeakHandle<gamedataChoiceCaptionIconPart_Record> _iconRecord;
		private CHandle<ScriptableDeviceAction> _action;
		private CName _slotName;
		private CEnum<gamedataStatPoolType> _statPoolType;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<EUploadProgramState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("progressBarType")] 
		public CEnum<EProgressBarType> ProgressBarType
		{
			get => GetProperty(ref _progressBarType);
			set => SetProperty(ref _progressBarType, value);
		}

		[Ordinal(2)] 
		[RED("progressBarContext")] 
		public CEnum<EProgressBarContext> ProgressBarContext
		{
			get => GetProperty(ref _progressBarContext);
			set => SetProperty(ref _progressBarContext, value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(4)] 
		[RED("iconRecord")] 
		public CWeakHandle<gamedataChoiceCaptionIconPart_Record> IconRecord
		{
			get => GetProperty(ref _iconRecord);
			set => SetProperty(ref _iconRecord, value);
		}

		[Ordinal(5)] 
		[RED("action")] 
		public CHandle<ScriptableDeviceAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(6)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(7)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		public UploadProgramProgressEvent()
		{
			_duration = 3.000000F;
			_statPoolType = new() { Value = Enums.gamedataStatPoolType.Invalid };
		}
	}
}
