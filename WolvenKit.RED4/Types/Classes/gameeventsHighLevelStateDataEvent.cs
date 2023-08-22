using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsHighLevelStateDataEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("currentHighLevelState")] 
		public CEnum<gamedataNPCHighLevelState> CurrentHighLevelState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(1)] 
		[RED("currentNPCEntityID")] 
		public entEntityID CurrentNPCEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public gameeventsHighLevelStateDataEvent()
		{
			CurrentHighLevelState = Enums.gamedataNPCHighLevelState.Invalid;
			CurrentNPCEntityID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
