using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SprintEvents : LocomotionGroundEvents
	{
		private CFloat _previousStimTimeStamp;
		private CHandle<gameStatModifierData_Deprecated> _reloadModifier;
		private CBool _isInSecondSprint;
		private CHandle<gameStatModifierData_Deprecated> _sprintModifier;

		[Ordinal(3)] 
		[RED("previousStimTimeStamp")] 
		public CFloat PreviousStimTimeStamp
		{
			get => GetProperty(ref _previousStimTimeStamp);
			set => SetProperty(ref _previousStimTimeStamp, value);
		}

		[Ordinal(4)] 
		[RED("reloadModifier")] 
		public CHandle<gameStatModifierData_Deprecated> ReloadModifier
		{
			get => GetProperty(ref _reloadModifier);
			set => SetProperty(ref _reloadModifier, value);
		}

		[Ordinal(5)] 
		[RED("isInSecondSprint")] 
		public CBool IsInSecondSprint
		{
			get => GetProperty(ref _isInSecondSprint);
			set => SetProperty(ref _isInSecondSprint, value);
		}

		[Ordinal(6)] 
		[RED("sprintModifier")] 
		public CHandle<gameStatModifierData_Deprecated> SprintModifier
		{
			get => GetProperty(ref _sprintModifier);
			set => SetProperty(ref _sprintModifier, value);
		}
	}
}
