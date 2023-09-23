using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinimalItemTooltipRecipeData : IScriptable
	{
		[Ordinal(0)] 
		[RED("statsNumber")] 
		public CInt32 StatsNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("damageTypes")] 
		public CArray<InventoryTooltipData_StatData> DamageTypes
		{
			get => GetPropertyValue<CArray<InventoryTooltipData_StatData>>();
			set => SetPropertyValue<CArray<InventoryTooltipData_StatData>>(value);
		}

		[Ordinal(2)] 
		[RED("recipeStats")] 
		public CArray<InventoryTooltipData_StatData> RecipeStats
		{
			get => GetPropertyValue<CArray<InventoryTooltipData_StatData>>();
			set => SetPropertyValue<CArray<InventoryTooltipData_StatData>>(value);
		}

		public MinimalItemTooltipRecipeData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
