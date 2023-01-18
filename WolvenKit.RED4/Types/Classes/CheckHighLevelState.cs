using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckHighLevelState : AINPCHighLevelStateCheck
	{
		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<gamedataNPCHighLevelState> State
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		public CheckHighLevelState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
