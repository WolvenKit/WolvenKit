using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCreditsSectionController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("sectionName")] 
		public inkTextWidgetReference SectionName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public gameuiCreditsSectionController()
		{
			SectionName = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
