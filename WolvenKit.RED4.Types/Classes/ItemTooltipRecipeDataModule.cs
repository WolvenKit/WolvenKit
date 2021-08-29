using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipRecipeDataModule : ItemTooltipModuleController
	{
		private inkTextWidgetReference _statsLabel;
		private inkWidgetReference _statsWrapper;
		private inkCompoundWidgetReference _statsContainer;
		private inkTextWidgetReference _damageTypesLabel;
		private inkWidgetReference _damageTypesWrapper;
		private inkCompoundWidgetReference _damageTypesContainer;

		[Ordinal(2)] 
		[RED("statsLabel")] 
		public inkTextWidgetReference StatsLabel
		{
			get => GetProperty(ref _statsLabel);
			set => SetProperty(ref _statsLabel, value);
		}

		[Ordinal(3)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetProperty(ref _statsWrapper);
			set => SetProperty(ref _statsWrapper, value);
		}

		[Ordinal(4)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetProperty(ref _statsContainer);
			set => SetProperty(ref _statsContainer, value);
		}

		[Ordinal(5)] 
		[RED("damageTypesLabel")] 
		public inkTextWidgetReference DamageTypesLabel
		{
			get => GetProperty(ref _damageTypesLabel);
			set => SetProperty(ref _damageTypesLabel, value);
		}

		[Ordinal(6)] 
		[RED("damageTypesWrapper")] 
		public inkWidgetReference DamageTypesWrapper
		{
			get => GetProperty(ref _damageTypesWrapper);
			set => SetProperty(ref _damageTypesWrapper, value);
		}

		[Ordinal(7)] 
		[RED("damageTypesContainer")] 
		public inkCompoundWidgetReference DamageTypesContainer
		{
			get => GetProperty(ref _damageTypesContainer);
			set => SetProperty(ref _damageTypesContainer, value);
		}
	}
}
