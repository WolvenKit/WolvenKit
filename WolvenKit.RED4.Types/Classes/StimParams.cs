using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StimParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("reactionOutput")] 
		public ReactionOutput ReactionOutput
		{
			get => GetPropertyValue<ReactionOutput>();
			set => SetPropertyValue<ReactionOutput>(value);
		}

		[Ordinal(1)] 
		[RED("stimData")] 
		public StimEventData StimData
		{
			get => GetPropertyValue<StimEventData>();
			set => SetPropertyValue<StimEventData>(value);
		}

		public StimParams()
		{
			ReactionOutput = new();
			StimData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
