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
			PostMortem = new() { TrackedQuest = new(), Location = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
