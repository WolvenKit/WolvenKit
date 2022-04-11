using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipRecipeDataModule : ItemTooltipModuleController
	{
		[Ordinal(2)] 
		[RED("randomQualityLabel")] 
		public inkTextWidgetReference RandomQualityLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("randomQualityWrapper")] 
		public inkWidgetReference RandomQualityWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("statsLabel")] 
		public inkTextWidgetReference StatsLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
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
		[RED("damageTypesLabel")] 
		public inkTextWidgetReference DamageTypesLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("damageTypesWrapper")] 
		public inkWidgetReference DamageTypesWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("damageTypesContainer")] 
		public inkCompoundWidgetReference DamageTypesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public ItemTooltipRecipeDataModule()
		{
			RandomQualityLabel = new();
			RandomQualityWrapper = new();
			StatsLabel = new();
			StatsWrapper = new();
			StatsContainer = new();
			DamageTypesLabel = new();
			DamageTypesWrapper = new();
			DamageTypesContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
