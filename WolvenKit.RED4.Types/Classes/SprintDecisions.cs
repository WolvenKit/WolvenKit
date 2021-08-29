using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SprintDecisions : LocomotionGroundDecisions
	{
		private CBool _sprintPressed;
		private CBool _toggleSprintPressed;

		[Ordinal(3)] 
		[RED("sprintPressed")] 
		public CBool SprintPressed
		{
			get => GetProperty(ref _sprintPressed);
			set => SetProperty(ref _sprintPressed, value);
		}

		[Ordinal(4)] 
		[RED("toggleSprintPressed")] 
		public CBool ToggleSprintPressed
		{
			get => GetProperty(ref _toggleSprintPressed);
			set => SetProperty(ref _toggleSprintPressed, value);
		}
	}
}
