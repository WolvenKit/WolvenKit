using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiContextChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("oldContext")] 
		public CBitField<gameuiContext> OldContext
		{
			get => GetPropertyValue<CBitField<gameuiContext>>();
			set => SetPropertyValue<CBitField<gameuiContext>>(value);
		}

		[Ordinal(1)] 
		[RED("newContext")] 
		public CBitField<gameuiContext> NewContext
		{
			get => GetPropertyValue<CBitField<gameuiContext>>();
			set => SetPropertyValue<CBitField<gameuiContext>>(value);
		}

		public gameuiContextChangedEvent()
		{
			OldContext = Enums.gameuiContext.MAX;
			NewContext = Enums.gameuiContext.MAX;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
