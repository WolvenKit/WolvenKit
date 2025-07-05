using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIHoldPositionCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIHoldPositionCommandParams()
		{
			Duration = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
