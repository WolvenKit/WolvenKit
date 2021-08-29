using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugColoring_Climbable : worldEditorDebugColoringSettings
	{
		private CColor _climbableColour;
		private CColor _notClimbableColour;

		[Ordinal(0)] 
		[RED("climbableColour")] 
		public CColor ClimbableColour
		{
			get => GetProperty(ref _climbableColour);
			set => SetProperty(ref _climbableColour, value);
		}

		[Ordinal(1)] 
		[RED("notClimbableColour")] 
		public CColor NotClimbableColour
		{
			get => GetProperty(ref _notClimbableColour);
			set => SetProperty(ref _notClimbableColour, value);
		}
	}
}
