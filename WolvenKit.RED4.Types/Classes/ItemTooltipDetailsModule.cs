using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipDetailsModule : ItemTooltipModuleController
	{
		[Ordinal(2)] 
		[RED("statsLine")] 
		public inkWidgetReference StatsLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("dedicatedModsLine")] 
		public inkWidgetReference DedicatedModsLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("dedicatedModsWrapper")] 
		public inkWidgetReference DedicatedModsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("dedicatedModsContainer")] 
		public inkCompoundWidgetReference DedicatedModsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("modsLine")] 
		public inkWidgetReference ModsLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("modsWrapper")] 
		public inkWidgetReference ModsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
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
		}
	}
}
