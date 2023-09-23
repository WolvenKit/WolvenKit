using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questJoinCrowdParams : questAICommandParams
	{
		[Ordinal(0)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questJoinCrowdParams()
		{
			RepeatCommandOnInterrupt = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
