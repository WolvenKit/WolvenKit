using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberspaceMappinController : gameuiQuestMappinController
	{
		[Ordinal(14)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public CyberspaceMappinController()
		{
			Image = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
