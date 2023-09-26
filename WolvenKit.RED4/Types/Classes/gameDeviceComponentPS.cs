using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDeviceComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("markAsQuest")] 
		public CBool MarkAsQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("autoToggleQuestMark")] 
		public CBool AutoToggleQuestMark
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("factToDisableQuestMark")] 
		public CName FactToDisableQuestMark
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("callbackToDisableQuestMarkID")] 
		public CUInt32 CallbackToDisableQuestMarkID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("backdoorObjectiveData")] 
		public CHandle<BackDoorObjectiveData> BackdoorObjectiveData
		{
			get => GetPropertyValue<CHandle<BackDoorObjectiveData>>();
			set => SetPropertyValue<CHandle<BackDoorObjectiveData>>(value);
		}

		[Ordinal(5)] 
		[RED("controlPanelObjectiveData")] 
		public CHandle<ControlPanelObjectiveData> ControlPanelObjectiveData
		{
			get => GetPropertyValue<CHandle<ControlPanelObjectiveData>>();
			set => SetPropertyValue<CHandle<ControlPanelObjectiveData>>(value);
		}

		[Ordinal(6)] 
		[RED("deviceUIStyle")] 
		public CEnum<gamedataComputerUIStyle> DeviceUIStyle
		{
			get => GetPropertyValue<CEnum<gamedataComputerUIStyle>>();
			set => SetPropertyValue<CEnum<gamedataComputerUIStyle>>(value);
		}

		[Ordinal(7)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(8)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isBeingScanned")] 
		public CBool IsBeingScanned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("exposeQuickHacks")] 
		public CBool ExposeQuickHacks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("isAttachedToGame")] 
		public CBool IsAttachedToGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("isLogicReady")] 
		public CBool IsLogicReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("maxDevicesToExtractInOneFrame")] 
		public CInt32 MaxDevicesToExtractInOneFrame
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameDeviceComponentPS()
		{
			AutoToggleQuestMark = true;
			DeviceUIStyle = Enums.gamedataComputerUIStyle.LightBlue;
			MaxDevicesToExtractInOneFrame = 10;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
