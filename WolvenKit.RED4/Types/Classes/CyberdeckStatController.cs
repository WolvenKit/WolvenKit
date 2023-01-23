using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberdeckStatController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public CyberdeckStatController()
		{
			Label = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
