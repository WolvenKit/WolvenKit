using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SlideEvents : CrouchEvents
	{
		[Ordinal(6)] 
		[RED("rumblePlayed")] 
		public CBool RumblePlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("addDecelerationModifier")] 
		public CHandle<gameStatModifierData_Deprecated> AddDecelerationModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		public SlideEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
