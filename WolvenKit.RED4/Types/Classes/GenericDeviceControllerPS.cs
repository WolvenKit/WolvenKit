using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GenericDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("isRecognizableBySenses")] 
		public CBool IsRecognizableBySenses
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(108)] 
		[RED("genericDeviceActionsSetup")] 
		public GenericDeviceActionsData GenericDeviceActionsSetup
		{
			get => GetPropertyValue<GenericDeviceActionsData>();
			set => SetPropertyValue<GenericDeviceActionsData>(value);
		}

		[Ordinal(109)] 
		[RED("genericDeviceSkillChecks")] 
		public CHandle<GenericContainer> GenericDeviceSkillChecks
		{
			get => GetPropertyValue<CHandle<GenericContainer>>();
			set => SetPropertyValue<CHandle<GenericContainer>>(value);
		}

		[Ordinal(110)] 
		[RED("deviceWidgetRecord")] 
		public TweakDBID DeviceWidgetRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(111)] 
		[RED("thumbnailWidgetRecord")] 
		public TweakDBID ThumbnailWidgetRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(112)] 
		[RED("performedCustomActionsIDs")] 
		public CArray<CName> PerformedCustomActionsIDs
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public GenericDeviceControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
