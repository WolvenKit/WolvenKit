using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipRecipeDataModule : ItemTooltipModuleController
	{
		[Ordinal(5)] 
		[RED("randomQualityLabel")] 
		public inkTextWidgetReference RandomQualityLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("randomQualityWrapper")] 
		public inkWidgetReference RandomQualityWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("statsLabel")] 
		public inkTextWidgetReference StatsLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("damageTypesLabel")] 
		public inkTextWidgetReference DamageTypesLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("damageTypesWrapper")] 
		public inkWidgetReference DamageTypesWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("damageTypesContainer")] 
		public inkCompoundWidgetReference DamageTypesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public ItemTooltipRecipeDataModule()
		{
			RandomQualityLabel = new inkTextWidgetReference();
			RandomQualityWrapper = new inkWidgetReference();
			StatsLabel = new inkTextWidgetReference();
			StatsWrapper = new inkWidgetReference();
			StatsContainer = new inkCompoundWidgetReference();
			DamageTypesLabel = new inkTextWidgetReference();
			DamageTypesWrapper = new inkWidgetReference();
			DamageTypesContainer = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
