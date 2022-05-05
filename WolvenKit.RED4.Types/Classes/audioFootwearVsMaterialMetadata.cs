using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioFootwearVsMaterialMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("footwearType")] 
		public CName FootwearType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("skidEvent")] 
		public CName SkidEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("defaultFootstep")] 
		public CName DefaultFootstep
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("locomotionStates")] 
		public CHandle<audioLocomotionStateEventDictionary> LocomotionStates
		{
			get => GetPropertyValue<CHandle<audioLocomotionStateEventDictionary>>();
			set => SetPropertyValue<CHandle<audioLocomotionStateEventDictionary>>(value);
		}

		[Ordinal(5)] 
		[RED("customActionEvents")] 
		public CHandle<audioLocomotionCustomActionEventDictionary> CustomActionEvents
		{
			get => GetPropertyValue<CHandle<audioLocomotionCustomActionEventDictionary>>();
			set => SetPropertyValue<CHandle<audioLocomotionCustomActionEventDictionary>>(value);
		}

		public audioFootwearVsMaterialMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
