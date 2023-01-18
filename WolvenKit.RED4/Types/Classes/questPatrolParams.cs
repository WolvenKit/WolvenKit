using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPatrolParams : questAICommandParams
	{
		[Ordinal(0)] 
		[RED("pathParams")] 
		public CHandle<AIPatrolPathParameters> PathParams
		{
			get => GetPropertyValue<CHandle<AIPatrolPathParameters>>();
			set => SetPropertyValue<CHandle<AIPatrolPathParameters>>(value);
		}

		[Ordinal(1)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questPatrolParams()
		{
			RepeatCommandOnInterrupt = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
