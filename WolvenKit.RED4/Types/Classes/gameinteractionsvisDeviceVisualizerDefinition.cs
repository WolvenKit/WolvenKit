using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsvisDeviceVisualizerDefinition : gameinteractionsvisIVisualizerDefinition
	{
		[Ordinal(1)] 
		[RED("interactionType")] 
		public CEnum<gameinteractionsvisInteractionType> InteractionType
		{
			get => GetPropertyValue<CEnum<gameinteractionsvisInteractionType>>();
			set => SetPropertyValue<CEnum<gameinteractionsvisInteractionType>>(value);
		}

		[Ordinal(2)] 
		[RED("displayNameOverride")] 
		public CString DisplayNameOverride
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("useDefaultActionMapping")] 
		public CBool UseDefaultActionMapping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("createMappin")] 
		public CBool CreateMappin
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isDynamic")] 
		public CBool IsDynamic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("timeProvider")] 
		public CHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider
		{
			get => GetPropertyValue<CHandle<gameinteractionsvisIVisualizerTimeProvider>>();
			set => SetPropertyValue<CHandle<gameinteractionsvisIVisualizerTimeProvider>>(value);
		}

		public gameinteractionsvisDeviceVisualizerDefinition()
		{
			IsDynamic = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
