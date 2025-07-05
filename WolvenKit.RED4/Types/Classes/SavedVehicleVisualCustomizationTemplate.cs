using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SavedVehicleVisualCustomizationTemplate : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hasUniqueTemplate")] 
		public CBool HasUniqueTemplate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("genericData")] 
		public GenericTemplatePersistentData GenericData
		{
			get => GetPropertyValue<GenericTemplatePersistentData>();
			set => SetPropertyValue<GenericTemplatePersistentData>(value);
		}

		[Ordinal(2)] 
		[RED("uniqueDataID")] 
		public TweakDBID UniqueDataID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("twintoneModelName")] 
		public CName TwintoneModelName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SavedVehicleVisualCustomizationTemplate()
		{
			GenericData = new GenericTemplatePersistentData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
