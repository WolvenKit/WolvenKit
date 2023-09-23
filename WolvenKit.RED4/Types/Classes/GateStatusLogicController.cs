using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GateStatusLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("textStatus")] 
		public inkTextWidgetReference TextStatus
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public GateStatusLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
