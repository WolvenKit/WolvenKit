using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTelemetryPostMortemContainer : ISerializable
	{
		[Ordinal(0)] 
		[RED("postMortem")] 
		public gameTelemetryPostMortem PostMortem
		{
			get => GetPropertyValue<gameTelemetryPostMortem>();
			set => SetPropertyValue<gameTelemetryPostMortem>(value);
		}

		public gameTelemetryPostMortemContainer()
		{
			PostMortem = new gameTelemetryPostMortem { TrackedQuest = new gameTelemetryTrackedQuest(), Location = new Vector3() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
