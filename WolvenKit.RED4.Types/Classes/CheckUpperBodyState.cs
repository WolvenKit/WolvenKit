using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckUpperBodyState : AINPCUpperBodyStateCheck
	{
		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<gamedataNPCUpperBodyState> State
		{
			get => GetPropertyValue<CEnum<gamedataNPCUpperBodyState>>();
			set => SetPropertyValue<CEnum<gamedataNPCUpperBodyState>>(value);
		}

		public CheckUpperBodyState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
