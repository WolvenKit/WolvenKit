using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIRoadBlockadeMemberCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIRoadBlockadeMemberCommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
