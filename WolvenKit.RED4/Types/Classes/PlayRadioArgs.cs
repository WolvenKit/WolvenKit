using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayRadioArgs : IScriptable
	{
		[Ordinal(0)] 
		[RED("instance")] 
		public ScriptGameInstance Instance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("onlyPlayIfPlayerIsBeingChased")] 
		public CBool OnlyPlayIfPlayerIsBeingChased
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("shouldCheckDistrictAfterDelay")] 
		public CBool ShouldCheckDistrictAfterDelay
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("handleVehicleEntranceEdgeCase")] 
		public CBool HandleVehicleEntranceEdgeCase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("handleVehicleLostOrSpottedEdgeCase")] 
		public CBool HandleVehicleLostOrSpottedEdgeCase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("stateUsedOnRequest")] 
		public CEnum<EStarState> StateUsedOnRequest
		{
			get => GetPropertyValue<CEnum<EStarState>>();
			set => SetPropertyValue<CEnum<EStarState>>(value);
		}

		public PlayRadioArgs()
		{
			Instance = new ScriptGameInstance();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
