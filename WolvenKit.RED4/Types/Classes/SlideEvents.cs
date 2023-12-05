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
		[RED("enteredWithSprint")] 
		public CBool EnteredWithSprint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("decelerating")] 
		public CBool Decelerating
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("perkDecelerationMultiplier")] 
		public CFloat PerkDecelerationMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("addDecelerationModifier")] 
		public CHandle<gameStatModifierData_Deprecated> AddDecelerationModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(11)] 
		[RED("multiplyDecelerationModifier")] 
		public CHandle<gameStatModifierData_Deprecated> MultiplyDecelerationModifier
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
