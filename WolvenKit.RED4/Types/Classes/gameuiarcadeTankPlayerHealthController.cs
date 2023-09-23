using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeTankPlayerHealthController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("health")] 
		public inkWidgetReference Health
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeTankPlayerHealthController()
		{
			Health = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
