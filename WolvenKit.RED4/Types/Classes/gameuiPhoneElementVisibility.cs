using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhoneElementVisibility : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tierVisibility")] 
		public CBitField<worlduiContextVisibility> TierVisibility
		{
			get => GetPropertyValue<CBitField<worlduiContextVisibility>>();
			set => SetPropertyValue<CBitField<worlduiContextVisibility>>(value);
		}

		[Ordinal(1)] 
		[RED("gameContextVisibility")] 
		public CBitField<gameuiContext> GameContextVisibility
		{
			get => GetPropertyValue<CBitField<gameuiContext>>();
			set => SetPropertyValue<CBitField<gameuiContext>>(value);
		}

		[Ordinal(2)] 
		[RED("slot")] 
		public inkCompoundWidgetReference Slot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public gameuiPhoneElementVisibility()
		{
			Slot = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
