using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAreaCrossingPerimeter : SecurityAreaEvent
	{
		[Ordinal(27)] 
		[RED("entered")] 
		public CBool Entered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecurityAreaCrossingPerimeter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
