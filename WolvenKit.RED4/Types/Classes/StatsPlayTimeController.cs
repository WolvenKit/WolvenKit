using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatsPlayTimeController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("playTimeRef")] 
		public inkTextWidgetReference PlayTimeRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("lifePathRef")] 
		public inkTextWidgetReference LifePathRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("lifePathIconRef")] 
		public inkImageWidgetReference LifePathIconRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public StatsPlayTimeController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
