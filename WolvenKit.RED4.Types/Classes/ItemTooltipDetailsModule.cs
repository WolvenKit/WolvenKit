using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipDetailsModule : ItemTooltipModuleController
	{
		[Ordinal(4)] 
		[RED("statsLine")] 
		public inkWidgetReference StatsLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("dedicatedModsLine")] 
		public inkWidgetReference DedicatedModsLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("dedicatedModsWrapper")] 
		public inkWidgetReference DedicatedModsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("dedicatedModsContainer")] 
		public inkCompoundWidgetReference DedicatedModsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("modsLine")] 
		public inkWidgetReference ModsLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("modsWrapper")] 
		public inkWidgetReference ModsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("modsContainer")] 
		public inkCompoundWidgetReference ModsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public ItemTooltipDetailsModule()
		{
			StatsLine = new();
			StatsWrapper = new();
			StatsContainer = new();
			DedicatedModsLine = new();
			DedicatedModsWrapper = new();
			DedicatedModsContainer = new();
			ModsLine = new();
			ModsWrapper = new();
			ModsContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
