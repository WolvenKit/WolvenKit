using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SoundSystemControllerPS : MasterControllerPS
	{
		private CInt32 _defaultAction;
		private CArray<SoundSystemSettings> _soundSystemSettings;
		private CHandle<ChangeMusicAction> _currentEvent;
		private CHandle<ChangeMusicAction> _cachedEvent;

		[Ordinal(105)] 
		[RED("defaultAction")] 
		public CInt32 DefaultAction
		{
			get => GetProperty(ref _defaultAction);
			set => SetProperty(ref _defaultAction, value);
		}

		[Ordinal(106)] 
		[RED("soundSystemSettings")] 
		public CArray<SoundSystemSettings> SoundSystemSettings
		{
			get => GetProperty(ref _soundSystemSettings);
			set => SetProperty(ref _soundSystemSettings, value);
		}

		[Ordinal(107)] 
		[RED("currentEvent")] 
		public CHandle<ChangeMusicAction> CurrentEvent
		{
			get => GetProperty(ref _currentEvent);
			set => SetProperty(ref _currentEvent, value);
		}

		[Ordinal(108)] 
		[RED("cachedEvent")] 
		public CHandle<ChangeMusicAction> CachedEvent
		{
			get => GetProperty(ref _cachedEvent);
			set => SetProperty(ref _cachedEvent, value);
		}
	}
}
