using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsHighLevelStateDataEvent : redEvent
	{
		private CEnum<gamedataNPCHighLevelState> _currentHighLevelState;
		private entEntityID _currentNPCEntityID;

		[Ordinal(0)] 
		[RED("currentHighLevelState")] 
		public CEnum<gamedataNPCHighLevelState> CurrentHighLevelState
		{
			get => GetProperty(ref _currentHighLevelState);
			set => SetProperty(ref _currentHighLevelState, value);
		}

		[Ordinal(1)] 
		[RED("currentNPCEntityID")] 
		public entEntityID CurrentNPCEntityID
		{
			get => GetProperty(ref _currentNPCEntityID);
			set => SetProperty(ref _currentNPCEntityID, value);
		}

		public gameeventsHighLevelStateDataEvent()
		{
			_currentHighLevelState = new() { Value = Enums.gamedataNPCHighLevelState.Invalid };
		}
	}
}
