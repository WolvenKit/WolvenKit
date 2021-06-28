using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_Climbable : worldEditorDebugColoringSettings
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

		public worldDebugColoring_Climbable(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
