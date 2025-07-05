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
			TextStatus = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
