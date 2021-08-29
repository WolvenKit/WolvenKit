using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipRequirementsModule : ItemTooltipModuleController
	{
		private inkWidgetReference _levelRequirementsWrapper;
		private inkWidgetReference _strenghtOrReflexWrapper;
		private inkWidgetReference _smartlinkGunWrapper;
		private inkWidgetReference _anyAttributeWrapper;
		private inkTextWidgetReference _levelRequirementsText;
		private inkTextWidgetReference _strenghtOrReflexText;
		private inkTextWidgetReference _anyAttributeText;

		[Ordinal(2)] 
		[RED("levelRequirementsWrapper")] 
		public inkWidgetReference LevelRequirementsWrapper
		{
			get => GetProperty(ref _levelRequirementsWrapper);
			set => SetProperty(ref _levelRequirementsWrapper, value);
		}

		[Ordinal(3)] 
		[RED("strenghtOrReflexWrapper")] 
		public inkWidgetReference StrenghtOrReflexWrapper
		{
			get => GetProperty(ref _strenghtOrReflexWrapper);
			set => SetProperty(ref _strenghtOrReflexWrapper, value);
		}

		[Ordinal(4)] 
		[RED("smartlinkGunWrapper")] 
		public inkWidgetReference SmartlinkGunWrapper
		{
			get => GetProperty(ref _smartlinkGunWrapper);
			set => SetProperty(ref _smartlinkGunWrapper, value);
		}

		[Ordinal(5)] 
		[RED("anyAttributeWrapper")] 
		public inkWidgetReference AnyAttributeWrapper
		{
			get => GetProperty(ref _anyAttributeWrapper);
			set => SetProperty(ref _anyAttributeWrapper, value);
		}

		[Ordinal(6)] 
		[RED("levelRequirementsText")] 
		public inkTextWidgetReference LevelRequirementsText
		{
			get => GetProperty(ref _levelRequirementsText);
			set => SetProperty(ref _levelRequirementsText, value);
		}

		[Ordinal(7)] 
		[RED("strenghtOrReflexText")] 
		public inkTextWidgetReference StrenghtOrReflexText
		{
			get => GetProperty(ref _strenghtOrReflexText);
			set => SetProperty(ref _strenghtOrReflexText, value);
		}

		[Ordinal(8)] 
		[RED("anyAttributeText")] 
		public inkTextWidgetReference AnyAttributeText
		{
			get => GetProperty(ref _anyAttributeText);
			set => SetProperty(ref _anyAttributeText, value);
		}
	}
}
