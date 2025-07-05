using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DoorPersistentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("doorType")] 
		public CEnum<EDoorType> DoorType
		{
			get => GetPropertyValue<CEnum<EDoorType>>();
			set => SetPropertyValue<CEnum<EDoorType>>(value);
		}

		[Ordinal(1)] 
		[RED("canPlayerToggleLockState")] 
		public CBool CanPlayerToggleLockState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("canPlayerToggleSealState")] 
		public CBool CanPlayerToggleSealState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("initialStatus")] 
		public CEnum<EDoorStatus> InitialStatus
		{
			get => GetPropertyValue<CEnum<EDoorStatus>>();
			set => SetPropertyValue<CEnum<EDoorStatus>>(value);
		}

		[Ordinal(4)] 
		[RED("keycardName")] 
		public TweakDBID KeycardName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("passcode")] 
		public CName Passcode
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public DoorPersistentData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
