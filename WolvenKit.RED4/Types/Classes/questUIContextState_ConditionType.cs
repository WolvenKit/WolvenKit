using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questUIContextState_ConditionType : questIUIConditionType
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CBitField<gameuiContext> State
		{
			get => GetPropertyValue<CBitField<gameuiContext>>();
			set => SetPropertyValue<CBitField<gameuiContext>>(value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questUIContextState_ConditionType()
		{
			State = Enums.gameuiContext.Default;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
