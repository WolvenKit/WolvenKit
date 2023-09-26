using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckPreviousHighLevelState : AINPCPreviousHighLevelStateCheck
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gamedataNPCHighLevelState> State
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		public CheckPreviousHighLevelState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
