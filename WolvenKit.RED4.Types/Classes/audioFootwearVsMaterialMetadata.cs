using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioFootwearVsMaterialMetadata : audioAudioMetadata
	{
		private CName _footwearType;
		private CName _skidEvent;
		private CName _defaultFootstep;
		private CHandle<audioLocomotionStateEventDictionary> _locomotionStates;
		private CHandle<audioLocomotionCustomActionEventDictionary> _customActionEvents;

		[Ordinal(1)] 
		[RED("footwearType")] 
		public CName FootwearType
		{
			get => GetProperty(ref _footwearType);
			set => SetProperty(ref _footwearType, value);
		}

		[Ordinal(2)] 
		[RED("skidEvent")] 
		public CName SkidEvent
		{
			get => GetProperty(ref _skidEvent);
			set => SetProperty(ref _skidEvent, value);
		}

		[Ordinal(3)] 
		[RED("defaultFootstep")] 
		public CName DefaultFootstep
		{
			get => GetProperty(ref _defaultFootstep);
			set => SetProperty(ref _defaultFootstep, value);
		}

		[Ordinal(4)] 
		[RED("locomotionStates")] 
		public CHandle<audioLocomotionStateEventDictionary> LocomotionStates
		{
			get => GetProperty(ref _locomotionStates);
			set => SetProperty(ref _locomotionStates, value);
		}

		[Ordinal(5)] 
		[RED("customActionEvents")] 
		public CHandle<audioLocomotionCustomActionEventDictionary> CustomActionEvents
		{
			get => GetProperty(ref _customActionEvents);
			set => SetProperty(ref _customActionEvents, value);
		}
	}
}
