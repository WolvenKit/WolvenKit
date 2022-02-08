using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
