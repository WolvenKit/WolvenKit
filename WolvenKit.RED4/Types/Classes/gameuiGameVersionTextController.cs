using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiGameVersionTextController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("gameVersionText")] 
		public inkTextWidgetReference GameVersionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("expansionWrapper")] 
		public inkCompoundWidgetReference ExpansionWrapper
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("fluffWrapper")] 
		public inkCompoundWidgetReference FluffWrapper
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public gameuiGameVersionTextController()
		{
			GameVersionText = new inkTextWidgetReference();
			ExpansionWrapper = new inkCompoundWidgetReference();
			FluffWrapper = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
