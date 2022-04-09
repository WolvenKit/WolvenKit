using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreviousFearPhaseCheck : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("fearPhase")] 
		public CInt32 FearPhase
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PreviousFearPhaseCheck()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
