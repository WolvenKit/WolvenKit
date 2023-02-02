using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SoundSystemControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("defaultAction")] 
		public CInt32 DefaultAction
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(106)] 
		[RED("soundSystemSettings")] 
		public CArray<SoundSystemSettings> SoundSystemSettings
		{
			get => GetPropertyValue<CArray<SoundSystemSettings>>();
			set => SetPropertyValue<CArray<SoundSystemSettings>>(value);
		}

		[Ordinal(107)] 
		[RED("currentEvent")] 
		public CHandle<ChangeMusicAction> CurrentEvent
		{
			get => GetPropertyValue<CHandle<ChangeMusicAction>>();
			set => SetPropertyValue<CHandle<ChangeMusicAction>>(value);
		}

		[Ordinal(108)] 
		[RED("cachedEvent")] 
		public CHandle<ChangeMusicAction> CachedEvent
		{
			get => GetPropertyValue<CHandle<ChangeMusicAction>>();
			set => SetPropertyValue<CHandle<ChangeMusicAction>>(value);
		}

		public SoundSystemControllerPS()
		{
			SoundSystemSettings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
