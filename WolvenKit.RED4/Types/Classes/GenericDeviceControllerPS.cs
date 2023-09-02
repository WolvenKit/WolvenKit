using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GenericDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("isRecognizableBySenses")] 
		public CBool IsRecognizableBySenses
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("genericDeviceActionsSetup")] 
		public GenericDeviceActionsData GenericDeviceActionsSetup
		{
			get => GetPropertyValue<GenericDeviceActionsData>();
			set => SetPropertyValue<GenericDeviceActionsData>(value);
		}

		[Ordinal(106)] 
		[RED("genericDeviceSkillChecks")] 
		public CHandle<GenericContainer> GenericDeviceSkillChecks
		{
			get => GetPropertyValue<CHandle<GenericContainer>>();
			set => SetPropertyValue<CHandle<GenericContainer>>(value);
		}

		[Ordinal(107)] 
		[RED("deviceWidgetRecord")] 
		public TweakDBID DeviceWidgetRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(108)] 
		[RED("thumbnailWidgetRecord")] 
		public TweakDBID ThumbnailWidgetRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(109)] 
		[RED("performedCustomActionsIDs")] 
		public CArray<CName> PerformedCustomActionsIDs
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public GenericDeviceControllerPS()
		{
			TweakDBDescriptionRecord = 143157997633;
			GenericDeviceActionsSetup = new GenericDeviceActionsData { StateActionsOverrides = new SGenericDeviceActionsData { ToggleON = new SDeviceActionBoolData(), TogglePower = new SDeviceActionBoolData() }, CustomActions = new SCustomDeviceActionsData { Actions = new() } };
			PerformedCustomActionsIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
