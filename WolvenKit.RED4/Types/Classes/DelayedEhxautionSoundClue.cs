using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayedEhxautionSoundClue : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("puppet")] 
		public CWeakHandle<gameObject> Puppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("audioEventName")] 
		public CName AudioEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public DelayedEhxautionSoundClue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
