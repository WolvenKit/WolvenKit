using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimationSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("cinematics")] 
		public animAnimSetCollection Cinematics
		{
			get => GetPropertyValue<animAnimSetCollection>();
			set => SetPropertyValue<animAnimSetCollection>(value);
		}

		[Ordinal(1)] 
		[RED("gameplay")] 
		public animAnimSetCollection Gameplay
		{
			get => GetPropertyValue<animAnimSetCollection>();
			set => SetPropertyValue<animAnimSetCollection>(value);
		}

		[Ordinal(2)] 
		[RED("finalAnimSetCollection")] 
		public animAnimSetCollection FinalAnimSetCollection
		{
			get => GetPropertyValue<animAnimSetCollection>();
			set => SetPropertyValue<animAnimSetCollection>(value);
		}

		public animAnimationSetup()
		{
			Cinematics = new() { AnimSets = new(), OverrideAnimSets = new(), AnimWrapperVariables = new() };
			Gameplay = new() { AnimSets = new(), OverrideAnimSets = new(), AnimWrapperVariables = new() };
			FinalAnimSetCollection = new() { AnimSets = new(), OverrideAnimSets = new(), AnimWrapperVariables = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
