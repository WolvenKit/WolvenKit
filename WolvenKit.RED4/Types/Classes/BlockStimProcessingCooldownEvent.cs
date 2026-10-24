using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BlockStimProcessingCooldownEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("stimData")] 
		public StimIdentificationData StimData
		{
			get => GetPropertyValue<StimIdentificationData>();
			set => SetPropertyValue<StimIdentificationData>(value);
		}

		public BlockStimProcessingCooldownEvent()
		{
			StimData = new StimIdentificationData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
