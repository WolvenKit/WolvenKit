using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UploadProgramProgressEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<EUploadProgramState> State
		{
			get => GetPropertyValue<CEnum<EUploadProgramState>>();
			set => SetPropertyValue<CEnum<EUploadProgramState>>(value);
		}

		[Ordinal(1)] 
		[RED("progressBarType")] 
		public CEnum<EProgressBarType> ProgressBarType
		{
			get => GetPropertyValue<CEnum<EProgressBarType>>();
			set => SetPropertyValue<CEnum<EProgressBarType>>(value);
		}

		[Ordinal(2)] 
		[RED("progressBarContext")] 
		public CEnum<EProgressBarContext> ProgressBarContext
		{
			get => GetPropertyValue<CEnum<EProgressBarContext>>();
			set => SetPropertyValue<CEnum<EProgressBarContext>>(value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("iconRecord")] 
		public CWeakHandle<gamedataChoiceCaptionIconPart_Record> IconRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataChoiceCaptionIconPart_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataChoiceCaptionIconPart_Record>>(value);
		}

		[Ordinal(5)] 
		[RED("action")] 
		public CHandle<ScriptableDeviceAction> Action
		{
			get => GetPropertyValue<CHandle<ScriptableDeviceAction>>();
			set => SetPropertyValue<CHandle<ScriptableDeviceAction>>(value);
		}

		[Ordinal(6)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		public UploadProgramProgressEvent()
		{
			Duration = 3.000000F;
			StatPoolType = Enums.gamedataStatPoolType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
