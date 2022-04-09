using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadialPointerController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("pointer")] 
		public inkImageWidgetReference Pointer
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("feedback")] 
		public inkImageWidgetReference Feedback
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public RadialPointerController()
		{
			Pointer = new();
			Feedback = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
