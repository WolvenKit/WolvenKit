using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModActionRequiredTypeInfoController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("reasonText")] 
		public inkTextWidgetReference ReasonText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("reasonIcon")] 
		public inkImageWidgetReference ReasonIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public ModActionRequiredTypeInfoController()
		{
			ReasonText = new inkTextWidgetReference();
			ReasonIcon = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
