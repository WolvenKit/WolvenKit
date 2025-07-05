using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCensorshipController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("censorshipFlags")] 
		public CBitField<CensorshipFlags> CensorshipFlags
		{
			get => GetPropertyValue<CBitField<CensorshipFlags>>();
			set => SetPropertyValue<CBitField<CensorshipFlags>>(value);
		}

		public inkCensorshipController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
