using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAnimationEventsOverrideNode : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("perActorOverrides")] 
		public CArray<questActorOverrideEntry> PerActorOverrides
		{
			get => GetPropertyValue<CArray<questActorOverrideEntry>>();
			set => SetPropertyValue<CArray<questActorOverrideEntry>>(value);
		}

		[Ordinal(1)] 
		[RED("GlobalMetadata")] 
		public CName GlobalMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questAnimationEventsOverrideNode()
		{
			PerActorOverrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
