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
			get
			{
				if (_statsNumber == null)
				{
					_statsNumber = (CInt32) CR2WTypeManager.Create("Int32", "statsNumber", cr2w, this);
				}
				return _statsNumber;
			}
			set
			{
				if (_statsNumber == value)
				{
					return;
				}
				_statsNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("damageTypes")] 
		public CArray<InventoryTooltipData_StatData> DamageTypes
		{
			get
			{
				if (_damageTypes == null)
				{
					_damageTypes = (CArray<InventoryTooltipData_StatData>) CR2WTypeManager.Create("array:InventoryTooltipData_StatData", "damageTypes", cr2w, this);
				}
				return _damageTypes;
			}
			set
			{
				if (_damageTypes == value)
				{
					return;
				}
				_damageTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("recipeStats")] 
		public CArray<InventoryTooltipData_StatData> RecipeStats
		{
			get
			{
				if (_recipeStats == null)
				{
					_recipeStats = (CArray<InventoryTooltipData_StatData>) CR2WTypeManager.Create("array:InventoryTooltipData_StatData", "recipeStats", cr2w, this);
				}
				return _recipeStats;
			}
			set
			{
				if (_recipeStats == value)
				{
					return;
				}
				_recipeStats = value;
				PropertySet(this);
			}
		}

		public MinimalItemTooltipRecipeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
