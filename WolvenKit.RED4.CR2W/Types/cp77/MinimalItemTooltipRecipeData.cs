using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipRecipeData : IScriptable
	{
		private CInt32 _statsNumber;
		private CArray<InventoryTooltipData_StatData> _damageTypes;
		private CArray<InventoryTooltipData_StatData> _recipeStats;

		[Ordinal(0)] 
		[RED("statsNumber")] 
		public CInt32 StatsNumber
		{
			get => GetProperty(ref _statsNumber);
			set => SetProperty(ref _statsNumber, value);
		}

		[Ordinal(1)] 
		[RED("damageTypes")] 
		public CArray<InventoryTooltipData_StatData> DamageTypes
		{
			get => GetProperty(ref _damageTypes);
			set => SetProperty(ref _damageTypes, value);
		}

		[Ordinal(2)] 
		[RED("recipeStats")] 
		public CArray<InventoryTooltipData_StatData> RecipeStats
		{
			get => GetProperty(ref _recipeStats);
			set => SetProperty(ref _recipeStats, value);
		}

		public MinimalItemTooltipRecipeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
