using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_Climbable : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("climbableColour")] 
		public CColor ClimbableColour
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("notClimbableColour")] 
		public CColor NotClimbableColour
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_Climbable()
		{
			ClimbableColour = new CColor { Green = 255, Alpha = 255 };
			NotClimbableColour = new CColor { Red = 255, Alpha = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
