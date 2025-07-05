using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckStanceState : AINPCStanceStateCheck
	{
		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<gamedataNPCStanceState> State
		{
			get => GetPropertyValue<CEnum<gamedataNPCStanceState>>();
			set => SetPropertyValue<CEnum<gamedataNPCStanceState>>(value);
		}

		public CheckStanceState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
