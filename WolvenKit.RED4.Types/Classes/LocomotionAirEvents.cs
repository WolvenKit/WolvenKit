using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LocomotionAirEvents : LocomotionEventsTransition
	{
		[Ordinal(3)] 
		[RED("maxSuperheroFallHeight")] 
		public CBool MaxSuperheroFallHeight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("updateInputToggles")] 
		public CBool UpdateInputToggles
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
